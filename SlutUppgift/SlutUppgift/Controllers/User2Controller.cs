using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SlutUppgift.Data;
using SlutUppgift.Models;

namespace SlutUppgift.Controllers
{
    public class User2Controller : Controller
    {
        private readonly SlutUppgiftContext _context;

        public User2Controller(SlutUppgiftContext context)
        {
            _context = context;
        }

        // GET: User2
        public async Task<IActionResult> Index()
        {
            return View(await _context.User2.ToListAsync());
        }

        // GET: User2/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user2 = await _context.User2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user2 == null)
            {
                return NotFound();
            }

            return View(user2);
        }

        // GET: User2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName2,PassWord2")] User2 user2)
        {
            if (ModelState.IsValid)
            {
                user2.Id = Guid.NewGuid();
                _context.Add(user2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user2);
        }

        // GET: User2/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user2 = await _context.User2.FindAsync(id);
            if (user2 == null)
            {
                return NotFound();
            }
            return View(user2);
        }

        // POST: User2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserName2,PassWord2")] User2 user2)
        {
            if (id != user2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!User2Exists(user2.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user2);
        }

        // GET: User2/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user2 = await _context.User2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user2 == null)
            {
                return NotFound();
            }

            return View(user2);
        }

        // POST: User2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user2 = await _context.User2.FindAsync(id);
            _context.User2.Remove(user2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool User2Exists(Guid id)
        {
            return _context.User2.Any(e => e.Id == id);
        }
    }
}
