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
    public class Author_BookController : ControllerBase
    {
        private readonly Context _context;

        public Author_BookController(Context context)
        {
            _context = context;
        }

        // GET: api/Author_Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author_Book>>> GetAuthor_Books()
        {
            return await _context.Author_Books.ToListAsync();
        }

        // GET: api/Author_Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Author_Book>> GetAuthor_Book(int id)
        {
            var author_Book = await _context.Author_Books.FindAsync(id);

            if (author_Book == null)
            {
                return NotFound();
            }

            return author_Book;
        }

        // PUT: api/Author_Book/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor_Book(int id, Author_Book author_Book)
        {
            if (id != author_Book.AuthurId)
            {
                return BadRequest();
            }

            _context.Entry(author_Book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Author_BookExists(id))
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

        // POST: api/Author_Book
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Author_Book>> PostAuthor_Book(Author_Book author_Book)
        {
            _context.Author_Books.Add(author_Book);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Author_BookExists(author_Book.AuthurId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAuthor_Book", new { id = author_Book.AuthurId }, author_Book);
        }

        // DELETE: api/Author_Book/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Author_Book>> DeleteAuthor_Book(int id)
        {
            var author_Book = await _context.Author_Books.FindAsync(id);
            if (author_Book == null)
            {
                return NotFound();
            }

            _context.Author_Books.Remove(author_Book);
            await _context.SaveChangesAsync();

            return author_Book;
        }

        private bool Author_BookExists(int id)
        {
            return _context.Author_Books.Any(e => e.AuthurId == id);
        }
    }
}
