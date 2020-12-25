using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebbBibliotek.Data;
using WebbBibliotek.Models;

namespace WebbBibliotek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly Context _context;

        public CustomersController(Context context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]   
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        /// fredriks saker
       
        [HttpPost("{customerId}/rentFilm/{filmId}")]
        public async Task<ActionResult<Customer>> RentBook(int customerId, int bookId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync();

            if (customer == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventories
                .Where(i => i.BookId == bookId)
                .Include(i => i.Rentals)
                .ToListAsync();

            var availableBook = inventory
                .FirstOrDefault(i => 
                i.Rentals == null 
                || i.Rentals.Count == 0 
                || i.Rentals.All(r => r.ReturnDate != null)
            );

            if (availableBook == null) // Kommer inte hoppa till nästa steg om film not in stock. 
            {
                return BadRequest("Film not in stock");
            }

            var rental = new Rental()
            {
                CustomerId = customerId,
                InventoryId = availableBook.InventoryId,
                RentalDate = DateTime.Now
            };

            _context.Rentals.Add(rental);
            await _context.SaveChangesAsync();

            return Ok("Film rented!");

            //Inventory availableInventoryItem = null;
            //foreach (var item in inventory) // Kolla om boken är tillgänglig. 
            //{
            //    if (item.Rentals == null)
            //    {
            //        availableInventoryItem = item;
            //    }
            //    else if(item.Rentals.Count == 0)
            //    {
            //        availableInventoryItem = item;
            //    }
            //    else if (item.Rentals.All(r => r.ReturnDate != null))
            //    {
            //        availableInventoryItem = item;
            //    }
            //}

            return Ok();
        }

        /// fredriks saker

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}
