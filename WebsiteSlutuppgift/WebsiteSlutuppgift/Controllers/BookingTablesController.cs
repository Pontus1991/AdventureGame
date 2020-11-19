using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using WebsiteSlutuppgift.Helpers;
using Microsoft.AspNetCore.Mvc;
using WebsiteSlutuppgift.Models;
using WebsiteSlutuppgift.Models.ViewModels;

namespace WebsiteSlutuppgift.Controllers
{

    [Authorize]  // (Roles = "Member, Admin")
    public class BookingTablesController : Controller
    {
        public BookingTablesController()
        {

        }

        // GET: Bookings
        public IActionResult Index()
        {
            var bookingTables = DbContext.BookingTables;
            return View(bookingTables);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            var createBookingTableViewModel = new CreateBookingTableViewModel() { Tables = DbContext.Tables };
            return View(createBookingTableViewModel);
        }

        // POST: Bookings/Create
        [HttpPost]
        // från vyn till metoden i controllen
        public IActionResult Create(BookingTable bookingTable)
        {
            if (!ValidateBookingTable(bookingTable))
            {
                var createBookingTableViewModel = new CreateBookingTableViewModel() { Tables = DbContext.Tables, BookingTable = bookingTable };
                return View(createBookingTableViewModel);
            }

            var tabelName = DbContext.Tables.FirstOrDefault(r => r.Id == bookingTable.TableId).Name;

            bookingTable.Id = Guid.NewGuid();
            bookingTable.TableName = tabelName;


            DbContext.BookingTables.Add(bookingTable);

            return RedirectToAction("Index");
        }

        private bool ValidateBookingTable(BookingTable bookingTable)
        {
            bool isValid = true;

            // Check if from date is after To date
            if (bookingTable.From > bookingTable.To)
            {
                ModelState.AddModelError("Booking.From", "Start date cannot be after end date");
                var createBookingTableViewModel = new CreateBookingTableViewModel() { Tables = DbContext.Tables, };
                isValid = false;
            }

            //1. Hämta ut alla bokning som har samma tableId som den nya bokningen
            List<BookingTable> bookingsFromDb = DbContext.BookingTables.Where(b => b.TableId == bookingTable.TableId).ToList();

            //2. Kolla om något av dessa bokningar har överlappande datum
            foreach (var oldBooking in bookingsFromDb)
            {
                if (DateHelpers.HasSharedDateIntervals(bookingTable.From, bookingTable.To, oldBooking.From, oldBooking.To))
                {
                    ModelState.AddModelError("Booking.From", "Date already occupied.");
                    var createBookingTableViewModel = new CreateBookingTableViewModel() { Tables = DbContext.Tables };
                    isValid = false;
                }
            }

            return isValid;
        }

        // GET: Bookings/Edit/5
        public IActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingTable = DbContext.BookingTables.FirstOrDefault(b => b.Id == id);

            if (bookingTable == null)
            {
                return NotFound();
            }

            var editBookingTableViewModel = new EditBookingTableViewModel() { BookingTable = bookingTable, Tables = DbContext.Tables };
            return View(editBookingTableViewModel);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        public IActionResult Edit(BookingTable bookingTable)
        {
            bookingTable.TableName = DbContext.Tables.FirstOrDefault(r => r.Id == bookingTable.TableId).Name;

            var bookingTableIndex = DbContext.BookingTables.FindIndex(m => m.Id == bookingTable.Id);

            if (bookingTableIndex == -1)
            {
                return NotFound();
            }

            DbContext.BookingTables[bookingTableIndex] = bookingTable;

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

            var table = DbContext.BookingTables.FirstOrDefault(r => r.Id == id);

            if (table == null)
            {
                return NotFound();
            }

            return View(table);
        }

        // POST: Bookings/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var table = DbContext.BookingTables.FirstOrDefault(r => r.Id == id);

            if (table == null)
            {
                return NotFound();
            }

            DbContext.BookingTables.Remove(table);

            return RedirectToAction("Index");
        }

    }
}
