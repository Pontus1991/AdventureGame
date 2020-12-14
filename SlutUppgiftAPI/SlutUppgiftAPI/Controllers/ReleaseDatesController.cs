using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlutUppgiftAPI.Data;
using SlutUppgiftAPI.Models;

namespace SlutUppgiftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReleaseDatesController : ControllerBase
    {
        private readonly Context _context;

        public ReleaseDatesController(Context context)
        {
            _context = context;
        }

        // GET: api/ReleaseDates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReleaseDate>>> GetReleaseDates()
        {
            return await _context.ReleaseDates.ToListAsync();
        }

        // GET: api/ReleaseDates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReleaseDate>> GetReleaseDate(int id)
        {
            var releaseDate = await _context.ReleaseDates.FindAsync(id);

            if (releaseDate == null)
            {
                return NotFound();
            }

            return releaseDate;
        }

        // PUT: api/ReleaseDates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReleaseDate(int id, ReleaseDate releaseDate)
        {
            if (id != releaseDate.ReleaseDateId)
            {
                return BadRequest();
            }

            _context.Entry(releaseDate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReleaseDateExists(id))
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

        // POST: api/ReleaseDates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ReleaseDate>> PostReleaseDate(ReleaseDate releaseDate)
        {
            _context.ReleaseDates.Add(releaseDate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReleaseDate", new { id = releaseDate.ReleaseDateId }, releaseDate);
        }

        // DELETE: api/ReleaseDates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReleaseDate>> DeleteReleaseDate(int id)
        {
            var releaseDate = await _context.ReleaseDates.FindAsync(id);
            if (releaseDate == null)
            {
                return NotFound();
            }

            _context.ReleaseDates.Remove(releaseDate);
            await _context.SaveChangesAsync();

            return releaseDate;
        }

        private bool ReleaseDateExists(int id)
        {
            return _context.ReleaseDates.Any(e => e.ReleaseDateId == id);
        }
    }
}
