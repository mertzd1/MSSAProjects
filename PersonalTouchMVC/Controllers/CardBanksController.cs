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
    public class CardBanksController : Controller
    {
        private readonly PersonalTouchDbContext _context;

        public CardBanksController(PersonalTouchDbContext context)
        {
            _context = context;
        }

        // GET: CardBanks
        public async Task<IActionResult> Index()
        {
            var personalTouchDbContext = _context.CardBank.Include(c => c.Event);
            return View(await personalTouchDbContext.ToListAsync());
        }

        // GET: CardBanks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardBank = await _context.CardBank
                .Include(c => c.Event)
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (cardBank == null)
            {
                return NotFound();
            }

            return View(cardBank);
        }

        // GET: CardBanks/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.EventDates, "EventId", "EventId");
            return View();
        }

        // POST: CardBanks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardId,EventId,CardFrontImagePath,CardBackImagePath")] CardBank cardBank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.EventDates, "EventId", "EventId", cardBank.EventId);
            return View(cardBank);
        }

        // GET: CardBanks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardBank = await _context.CardBank.FindAsync(id);
            if (cardBank == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.EventDates, "EventId", "EventId", cardBank.EventId);
            return View(cardBank);
        }

        // POST: CardBanks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CardId,EventId,CardFrontImagePath,CardBackImagePath")] CardBank cardBank)
        {
            if (id != cardBank.CardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardBank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardBankExists(cardBank.CardId))
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
            ViewData["EventId"] = new SelectList(_context.EventDates, "EventId", "EventId", cardBank.EventId);
            return View(cardBank);
        }

        // GET: CardBanks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardBank = await _context.CardBank
                .Include(c => c.Event)
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (cardBank == null)
            {
                return NotFound();
            }

            return View(cardBank);
        }

        // POST: CardBanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardBank = await _context.CardBank.FindAsync(id);
            _context.CardBank.Remove(cardBank);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardBankExists(int id)
        {
            return _context.CardBank.Any(e => e.CardId == id);
        }
    }
}
