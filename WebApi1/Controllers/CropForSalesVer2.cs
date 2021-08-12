using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi1.Models;


namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropForSalesVer2 : ControllerBase
    {
        private readonly FarmerSchemeContext _context;

        public CropForSalesVer2(FarmerSchemeContext context)
        {
            _context = context; 
        }

        // GET: api/CropForSalesVer2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CropForSale>>> GetCropForSales()
        {
            return await _context.CropForSales.ToListAsync();
        }

        // GET: api/CropForSalesVer2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CropForSale>> GetCropForSale(int id)
        {
            var cropForSale = await _context.CropForSales.FindAsync(id);

            if (cropForSale == null)
            {
                return NotFound();
            }

            return cropForSale;
        }

        // PUT: api/CropForSalesVer2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCropForSale(int id, CropForSale cropForSale)
        {
            if (id != cropForSale.CropId)
            {
                return BadRequest();
            }

            _context.Entry(cropForSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CropForSaleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CropForSalesVer2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CropForSale>> PostCropForSale(CropForSale cropForSale)
        {
            _context.CropForSales.Add(cropForSale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCropForSale", new { id = cropForSale.CropId }, cropForSale);

            //_context.CropForSales.Add(cropForSale);
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (CropForSaleExists(cropForSale.CropId))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtAction("GetCrop", new { id = cropForSale.CropId }, cropForSale);
        }

    

    // DELETE: api/CropForSalesVer2/5
    [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCropForSale(int id)
        {
            var cropForSale = await _context.CropForSales.FindAsync(id);
            if (cropForSale == null)
            {
                return NotFound();
            }

            _context.CropForSales.Remove(cropForSale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CropForSaleExists(int id)
        {
            return _context.CropForSales.Any(e => e.CropId == id);
        }
    }
}
