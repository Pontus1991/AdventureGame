using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hemsida.Data;
using Hemsida.Models;
using RoomBookingV3.Controllers;

namespace Hemsida.Controllers
{
    public class LoginsController : Controller
    {
        private readonly HemsidaContext _context;

        public LoginsController(HemsidaContext context)
        {
            _context = context;
        }

        // GET: Logins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Login.ToListAsync());
        }

        // GET: Logins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login
                .FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }

            return View(login);
        }

        // GET: Logins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,PassWord")] Login login)
        {
            if (ModelState.IsValid && login.UserName == "Pontus" && login.PassWord == "Frojd") // En slags validation... 
            {
                _context.Add(login);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(login);

        }

        // GET: Logins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }
            return View(login);
        }

        // POST: Logins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,PassWord")] Login login)
        {
            if (id != login.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(login);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginExists(login.Id))
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
            return View(login);
        }

        // GET: Logins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var login = await _context.Login
                .FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }

            return View(login);
        }

        // POST: Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var login = await _context.Login.FindAsync(id);
            _context.Login.Remove(login);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginExists(int id)
        {
            return _context.Login.Any(e => e.Id == id);
        }
    }
}
