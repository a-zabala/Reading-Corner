using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Reading_Corner.Entities;
using Reading_Corner.Models;
using Reading_Corner.Data;

namespace Reading_Corner.Controllers
{
    public class ReadingController: Controller
    {
        private readonly ApplicationDbContext _context;

        public ReadingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reading
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReadingRecords.ToListAsync());
        }

        // GET: Reading/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingRecord = await _context.ReadingRecords
                .SingleOrDefaultAsync(m => m.ID == id);
            if (readingRecord == null)
            {
                return NotFound();
            }

            return View(readingRecord);
        }

        // GET: Reading/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reading/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,,Name,LogDate,Minutes,Pages")] ReadingRecord readingRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(readingRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(readingRecord);
        }

        // GET: Reading/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingRecord = await _context.ReadingRecords.SingleOrDefaultAsync(m => m.ID == id);
            if (readingRecord == null)
            {
                return NotFound();
            }
            return View(readingRecord);
        }
        public async Task<IActionResult> Student(int? id)
        {
            return View("Index",await _context.ReadingRecords.Where(x => x.StudentID==id).ToListAsync());
        }
        // POST: Reading/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,LogDate,Minutes,Pages")] ReadingRecord readingRecord)
        {
            if (id != readingRecord.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(readingRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReadingRecordExists(readingRecord.ID))
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
            return View(readingRecord);
        }

        // GET: Reading/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingRecord = await _context.ReadingRecords
                .SingleOrDefaultAsync(m => m.ID == id);
            if (readingRecord == null)
            {
                return NotFound();
            }

            return View(readingRecord);
        }

        // POST: Reading/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var readingRecord = await _context.ReadingRecords.SingleOrDefaultAsync(m => m.ID == id);
            _context.ReadingRecords.Remove(readingRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReadingRecordExists(int id)
        {
            return _context.ReadingRecords.Any(e => e.ID == id);
        }
    }
}
