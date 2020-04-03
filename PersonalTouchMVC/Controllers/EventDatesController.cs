using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersonalTouchMVC.Data;
using PersonalTouchMVC.Models;

namespace PersonalTouchMVC.Controllers
{
    public class EventDatesController : Controller
    {
        private readonly PersonalTouchDbContext _context;

        public EventDatesController(PersonalTouchDbContext context)
        {
            _context = context;
        }

        // GET: EventDates
        public async Task<IActionResult> Index()
        {
            var personalTouchDbContext = _context.EventDates.Include(e => e.Contact);
            return View(await personalTouchDbContext.ToListAsync());
        }

        // GET: EventDates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventDates = await _context.EventDates
                .Include(e => e.Contact)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (eventDates == null)
            {
                return NotFound();
            }

            return View(eventDates);
        }

        // GET: EventDates/Create
        public IActionResult Create()
        {
            ViewData["ContactId"] = new SelectList(_context.Contacts, "ContactId", "ContactId");
            return View();
        }

        // POST: EventDates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventId,EventName,EventDate,ContactId")] EventDates eventDates)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventDates);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContactId"] = new SelectList(_context.Contacts, "ContactId", "ContactId", eventDates.ContactId);
            return View(eventDates);
        }

        // GET: EventDates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventDates = await _context.EventDates.FindAsync(id);
            if (eventDates == null)
            {
                return NotFound();
            }
            ViewData["ContactId"] = new SelectList(_context.Contacts, "ContactId", "ContactId", eventDates.ContactId);
            return View(eventDates);
        }

        // POST: EventDates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,EventName,EventDate,ContactId")] EventDates eventDates)
        {
            if (id != eventDates.EventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventDates);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventDatesExists(eventDates.EventId))
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
            ViewData["ContactId"] = new SelectList(_context.Contacts, "ContactId", "ContactId", eventDates.ContactId);
            return View(eventDates);
        }

        // GET: EventDates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventDates = await _context.EventDates
                .Include(e => e.Contact)
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (eventDates == null)
            {
                return NotFound();
            }

            return View(eventDates);
        }

        // POST: EventDates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventDates = await _context.EventDates.FindAsync(id);
            _context.EventDates.Remove(eventDates);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventDatesExists(int id)
        {
            return _context.EventDates.Any(e => e.EventId == id);
        }
    }
}
