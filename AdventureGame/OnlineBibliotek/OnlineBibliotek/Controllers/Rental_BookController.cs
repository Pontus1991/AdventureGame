using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBibliotek.Data;
using OnlineBibliotek.Models;

namespace OnlineBibliotek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rental_BookController : ControllerBase
    {
        private readonly Context _context;

        public Rental_BookController(Context context)
        {
            _context = context;
        }

        // GET: api/Rental_Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rental_Book>>> GetRental_Books()
        {
            return await _context.Rental_Books.ToListAsync();
        }

        // GET: api/Rental_Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rental_Book>> GetRental_Book(int id)
        {
            var rental_Book = await _context.Rental_Books.FindAsync(id);

            if (rental_Book == null)
            {
                return NotFound();
            }

            return rental_Book;
        }

        // PUT: api/Rental_Book/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRental_Book(int id, Rental_Book rental_Book)
        {
            if (id != rental_Book.RentalId)
            {
                return BadRequest();
            }

            _context.Entry(rental_Book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Rental_BookExists(id))
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

        // POST: api/Rental_Book
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rental_Book>> PostRental_Book(Rental_Book rental_Book)
        {
            _context.Rental_Books.Add(rental_Book);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Rental_BookExists(rental_Book.RentalId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRental_Book", new { id = rental_Book.RentalId }, rental_Book);
        }

        // DELETE: api/Rental_Book/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rental_Book>> DeleteRental_Book(int id)
        {
            var rental_Book = await _context.Rental_Books.FindAsync(id);
            if (rental_Book == null)
            {
                return NotFound();
            }

            _context.Rental_Books.Remove(rental_Book);
            await _context.SaveChangesAsync();

            return rental_Book;
        }

        private bool Rental_BookExists(int id)
        {
            return _context.Rental_Books.Any(e => e.RentalId == id);
        }
    }
}
