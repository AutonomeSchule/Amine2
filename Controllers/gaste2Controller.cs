using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AMINEV02.Models;

namespace AmineV02.Controllers
{
    public class gaste2Controller : Controller
    {
        private readonly AMINEV02Context _context;

        public gaste2Controller(AMINEV02Context context)
        {
            _context = context;
        }

        // GET: gaste2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gaeste.ToListAsync());
        }

        // GET: gaste2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gaeste = await _context.Gaeste
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gaeste == null)
            {
                return NotFound();
            }

            return View(gaeste);
        }

        // GET: gaste2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: gaste2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Ankunft,Genre,Price,Phonenumber,Email,vegan")] Gaeste gaeste)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gaeste);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gaeste);
        }

        // GET: gaste2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gaeste = await _context.Gaeste.SingleOrDefaultAsync(m => m.ID == id);
            if (gaeste == null)
            {
                return NotFound();
            }
            return View(gaeste);
        }

        // POST: gaste2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Ankunft,Genre,Price,Phonenumber,Email,vegan")] Gaeste gaeste)
        {
            if (id != gaeste.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gaeste);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaesteExists(gaeste.ID))
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
            return View(gaeste);
        }

        // GET: gaste2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gaeste = await _context.Gaeste
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gaeste == null)
            {
                return NotFound();
            }

            return View(gaeste);
        }

        // POST: gaste2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gaeste = await _context.Gaeste.SingleOrDefaultAsync(m => m.ID == id);
            _context.Gaeste.Remove(gaeste);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaesteExists(int id)
        {
            return _context.Gaeste.Any(e => e.ID == id);
        }
    }
}
