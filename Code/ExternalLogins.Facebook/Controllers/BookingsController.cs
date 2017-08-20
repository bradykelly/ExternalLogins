using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExternalLogins.Facebook.Data;
using ExternalLogins.Facebook.Data.Models;

namespace ExternalLogins.Facebook.Controllers
{
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private const string DateFormat = "yyyyMMdd";

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Bookings
        public IActionResult Index()
        {
            var model = new List<Booking>();
            model.AddRange(GetTestBookings());
            return View(model);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Start,End,Description")] Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        private bool BookingExists(int id)
        {
            return _context.Booking.Any(e => e.Id == id);
        }

        private IEnumerable<Booking> GetTestBookings()
        {
            var model = new List<Booking>();
            model.Add(new Booking
            {
                End = DateTime.ParseExact("20170815", DateFormat, CultureInfo.InvariantCulture),
                Start = DateTime.ParseExact("20170816", DateFormat, CultureInfo.InvariantCulture),
                Description = $"Booking No: 1"
            });
            model.Add(new Booking
            {
                ////End = DateTime.ParseExact("20190115", DateFormat, CultureInfo.InvariantCulture),
                Start = DateTime.ParseExact("20190112", DateFormat, CultureInfo.InvariantCulture),
                Description = $"Booking No: 2"
            });
            model.Add(new Booking
            {
                End = DateTime.ParseExact("20170221", DateFormat, CultureInfo.InvariantCulture),
                Start = DateTime.ParseExact("20170716", DateFormat, CultureInfo.InvariantCulture),
                Description = $"Booking No: 3"
            });
            return model;
        }
    }
}
