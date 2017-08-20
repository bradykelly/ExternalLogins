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

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .SingleOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Start,End,Description")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
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

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .SingleOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Booking.SingleOrDefaultAsync(m => m.Id == id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
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
                End = DateTime.ParseExact("20170815", DateFormat, CultureInfo.InvariantCulture),
                Start = DateTime.ParseExact("20170816", DateFormat, CultureInfo.InvariantCulture),
                Description = $"Booking No: 2"
            });
            model.Add(new Booking
            {
                End = DateTime.ParseExact("20170815", DateFormat, CultureInfo.InvariantCulture),
                Start = DateTime.ParseExact("20170816", DateFormat, CultureInfo.InvariantCulture),
                Description = $"Booking No: 3"
            });
            return model;
        }
    }
}
