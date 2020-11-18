using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebsiteSlutuppgift.Models;
using WebsiteSlutuppgift.Models.ViewModels;
using System.Collections.Generic;

namespace WebsiteSlutuppgift.Controllers
{

    [Authorize]  // Måste vara inloggad för att kunna boka. 
    public class BookingsController : Controller
    {
        public BookingsController()
        {

        }

        // GET: Bookings
        public IActionResult Index()
        {
            var bookings = DbContext.Bookings;
            return View(bookings);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            var createBookingViewModel = new CreateBookingViewModel() { Tracks = DbContext.Tracks };
            return View(createBookingViewModel);
        }

        // POST: Bookings/Create
        [HttpPost]
        // från vyn till metoden i controllen
        public IActionResult Create(Booking booking)
        {
            //// 1. Hämta it alla bokning som har somma roomId som den nya bokningen 
            /// /// 2. Kolla om något av dessa bokningar har överlappande datum. Linqqueryn har hämtat ut alla bokningar i listan och jämför med det rum vi försöker lägga bokningen på.
            /// Foreachen: Båda villkorlen måste vara uppfyllda för att man inte ska kunna boka längre fram där det kanske finns en bokning och tvärtom
            

            List<Booking> oldBookings = DbContext.Bookings.Where(b => b.TrackId == booking.TrackId).ToList();

            Boolean occupied = false;
            foreach (var oldBooking in oldBookings)
            {
                // Kolla om from är inom intervaölöet för bokninge
                // (booking.From > oldBooking.From && booking.To < oldBooking.To)

                // Kolla om to är inom intervallet för bokiningen 
                // (booking.From > oldBooking.To && booking.To < oldBooking.To)

                //  Tagit bort alla likamededtecken för att inte krocka på heltimme etc.. 

                if ((booking.From > oldBooking.From && booking.From < oldBooking.To) 
                   || (booking.To > oldBooking.From && booking.To < oldBooking.To)) // Måste göra två checkar
                {
                    occupied = true;
                }
            }


            var track = DbContext.Tracks.FirstOrDefault(r => r.Id == booking.TrackId);
            
            //if (track == null)
            //{
            //    return RedirectToAction(nameof(Create));
            //}

            booking.Id = Guid.NewGuid(); 
            booking.TrackName = track.Name;

            DbContext.Bookings.Add(booking);

            return RedirectToAction("Index");
        }

        // GET: Bookings/Edit/5
        public IActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = DbContext.Bookings.FirstOrDefault(b => b.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            var editBookingViewModel = new EditBookingViewModel() { Booking = booking, Tracks = DbContext.Tracks };
            return View(editBookingViewModel);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            booking.TrackName = DbContext.Tracks.FirstOrDefault(r => r.Id == booking.TrackId).Name;

            var bookingIndex = DbContext.Bookings.FindIndex(m => m.Id == booking.Id);

            if (bookingIndex == -1)
            {
                return NotFound();
            }

            DbContext.Bookings[bookingIndex] = booking;

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")] 
        // GET: Bookings/Delete/5
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = DbContext.Bookings.FirstOrDefault(r => r.Id == id);

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
            var room = DbContext.Bookings.FirstOrDefault(r => r.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            DbContext.Bookings.Remove(room);

            return RedirectToAction("Index");
        }

    }
}
