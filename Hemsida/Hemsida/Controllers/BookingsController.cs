using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Hemsida.Models;
using Hemsida.Models.ViewModels;

namespace Hemsida.Controllers
{
    public class BookingsController : Controller
    {
        public BookingsController()
        {

        }

        // GET: Bookings
        public IActionResult Index()
        {
            var bookings = DbContextLista.Bookings;

            return View(bookings);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            var createBookingViewModel = new CreateBookingViewModel() { Rooms = DbContextLista.Rooms };
            return View(createBookingViewModel);
        }

        // POST: Bookings/Create
        [HttpPost]
        // från vyn till metoden i controllen
        public IActionResult Create(Booking booking)
        {
            var room = DbContextLista.Rooms.FirstOrDefault(r => r.Id == booking.RoomId);

            if (room == null)
            {
                return RedirectToAction(nameof(Create));
            }

            booking.Id = Guid.NewGuid();
            booking.RoomName = room.Name;

            DbContextLista.Bookings.Add(booking);

            return RedirectToAction("Index");
        }

        // GET: Bookings/Edit/5
        public IActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = DbContextLista.Bookings.FirstOrDefault(b => b.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            var editBookingViewModel = new EditBookingViewModel() { Booking = booking, Rooms = DbContextLista.Rooms };
            return View(editBookingViewModel);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            booking.RoomName = DbContextLista.Rooms.FirstOrDefault(r => r.Id == booking.RoomId).Name;

            var bookingIndex = DbContextLista.Bookings.FindIndex(m => m.Id == booking.Id);

            if (bookingIndex == -1)
            {
                return NotFound();
            }

            DbContextLista.Bookings[bookingIndex] = booking;

            return RedirectToAction(nameof(Index));
        }

        // GET: Bookings/Delete/5
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = DbContextLista.Bookings.FirstOrDefault(r => r.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Bookings/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var room = DbContextLista.Bookings.FirstOrDefault(r => r.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            DbContextLista.Bookings.Remove(room);

            return RedirectToAction("Index");
        }

    }
}
