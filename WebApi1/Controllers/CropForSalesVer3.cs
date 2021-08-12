using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropForSalesVer3 : ControllerBase
    {
        private readonly FarmerSchemeContext _context;

        public CropForSalesVer3(FarmerSchemeContext context)
        {
            _context = context;
        }

        // POST: api/CropForSalesVer3
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CropForSale>> PostCropForSale(CropForSale cropForSale)
        {
            _context.CropForSales.Add(cropForSale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCropForSale", new { id = cropForSale.CropId }, cropForSale);
        }

        // GET: api/CropForSalesVer3
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CropForSale>>> GetCropForSales()
        {
            return await _context.CropForSales.ToListAsync();
        }

        // GET: api/CropForSalesVer3/5
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

        // PUT: api/CropForSalesVer3/5
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

        

        // DELETE: api/CropForSalesVer3/5
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
        public class UploadController : ControllerBase
        {
            [HttpPost, DisableRequestSizeLimit]
            public async Task<IActionResult> Upload()
            {
                try
                {
                    var formCollection = await Request.ReadFormAsync();
                    var file = formCollection.Files.First();
                    
                    var folderName = Path.Combine("StaticFiles", "Files");
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var fullPath = Path.Combine(pathToSave, fileName);
                        var dbPath = Path.Combine(folderName, fileName);

                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                            

                        return Ok(new { dbPath });
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex}");
                }
            }
        }
    }
}
