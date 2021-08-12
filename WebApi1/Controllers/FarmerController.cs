using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi1.Models;
using System.Net;



namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmerController : ControllerBase
    {
        private readonly FarmerSchemeContext db;
        public FarmerController(FarmerSchemeContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult GetCrop()
        {
            List<CropForSale> crop = db.CropForSales.ToList();
            if (crop.Count > 0)
            {
                return Ok(crop);

            }
            else
            {
                return BadRequest("Invalid");

            }

        }



        [HttpPost]
        public IActionResult AddCrop([FromBody] CropForSale crop)
        {

            db.CropForSales.Add(crop);
            db.SaveChanges();
            return Accepted();
        }
        //public HttpResponseMessage AddCrop([FromBody] CropForSale crop)
        //{
        //    db.CropForSales.Add(crop);
        //    db.SaveChanges();
        //    return Request.CreateResponse<CropForSale>(HttpStatusCode.OK, crop);
        //}
    }
}