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
    public class CardTemplatesController : Controller
    {
        private readonly PersonalTouchDbContext _context;

        public CardTemplatesController(PersonalTouchDbContext context)
        {
            _context = context;
        }

        // GET: CardTemplates
        public async Task<IActionResult> Index()
        {
            return View(await _context.CardTemplate.ToListAsync());
        }

        // GET: CardTemplates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTemplate = await _context.CardTemplate
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (cardTemplate == null)
            {
                return NotFound();
            }

            return View(cardTemplate);
        }

        // GET: CardTemplates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CardTemplates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardId,CardName,Url,TimesTemplateSelected,CardCategory")] CardTemplate cardTemplate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardTemplate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cardTemplate);
        }

        // GET: CardTemplates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTemplate = await _context.CardTemplate.FindAsync(id);
            if (cardTemplate == null)
            {
                return NotFound();
            }
            return View(cardTemplate);
        }

        // POST: CardTemplates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CardId,CardName,Url,TimesTemplateSelected,CardCategory")] CardTemplate cardTemplate)
        {
            if (id != cardTemplate.CardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardTemplate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardTemplateExists(cardTemplate.CardId))
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
            return View(cardTemplate);
        }

        // GET: CardTemplates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTemplate = await _context.CardTemplate
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (cardTemplate == null)
            {
                return NotFound();
            }

            return View(cardTemplate);
        }

        // POST: CardTemplates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardTemplate = await _context.CardTemplate.FindAsync(id);
            _context.CardTemplate.Remove(cardTemplate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardTemplateExists(int id)
        {
            return _context.CardTemplate.Any(e => e.CardId == id);
        }
    }
}
