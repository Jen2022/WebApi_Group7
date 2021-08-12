using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldHistoryController : ControllerBase
    {
        private readonly FarmerSchemeContext db;
        public SoldHistoryController(FarmerSchemeContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Soldhistory([FromQuery(Name = "FarmerId")] int Farmerid)
        {
            dynamic res;
            try
            {
                res = from c in db.CropForSales
                      where ( c.UserId == Farmerid && c.StatusOfCropSell== "approved")
                       select new
                      {
                           CropId = c.CropId,
                           CropName = c.CropName,
                           CropType = c.CropType,
                           SoldPrice = c.SoldPrice,
                      };

            }
            catch (Exception e)
            {
                return NotFound("No Found Details!!!!");
            }
            
            return Ok(res);
        }
    }
}

