using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    public class CropForSalesController : Controller
    {
        private readonly FarmerSchemeContext _context;

        public CropForSalesController(FarmerSchemeContext context)
        {
            _context = context;
        }

        // GET: CropForSales
        public async Task<IActionResult> Index()
        {
            var farmerSchemeContext = _context.CropForSales.Include(c => c.User);
            return View(await farmerSchemeContext.ToListAsync());
        }

        // GET: CropForSales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cropForSale = await _context.CropForSales
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CropId == id);
            if (cropForSale == null)
            {
                return NotFound();
            }

            return View(cropForSale);
        }

        // GET: CropForSales/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.TblUsers, "UserId", "AadharCard");
            return View();
        }

        // POST: CropForSales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CropId,UserId,CropType,CropName,Quantity,SoilPh,DateOfSoldCrop,Msp,SoldPrice,TotalPrice,StatusOfCropSell")] CropForSale cropForSale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cropForSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.TblUsers, "UserId", "AadharCard", cropForSale.UserId);
            return View(cropForSale);
        }

        // GET: CropForSales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cropForSale = await _context.CropForSales.FindAsync(id);
            if (cropForSale == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.TblUsers, "UserId", "AadharCard", cropForSale.UserId);
            return View(cropForSale);
        }

        // POST: CropForSales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CropId,UserId,CropType,CropName,Quantity,SoilPh,DateOfSoldCrop,Msp,SoldPrice,TotalPrice,StatusOfCropSell")] CropForSale cropForSale)
        {
            if (id != cropForSale.CropId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cropForSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CropForSaleExists(cropForSale.CropId))
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
            ViewData["UserId"] = new SelectList(_context.TblUsers, "UserId", "AadharCard", cropForSale.UserId);
            return View(cropForSale);
        }

        // GET: CropForSales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cropForSale = await _context.CropForSales
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CropId == id);
            if (cropForSale == null)
            {
                return NotFound();
            }

            return View(cropForSale);
        }

        // POST: CropForSales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cropForSale = await _context.CropForSales.FindAsync(id);
            _context.CropForSales.Remove(cropForSale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CropForSaleExists(int id)
        {
            return _context.CropForSales.Any(e => e.CropId == id);
        }
    }
}
