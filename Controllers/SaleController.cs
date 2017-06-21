using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDApplication.DBModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;


namespace CRUDApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [EnableCors("CorsPolicy")]
    public class SaleController : Controller
    {
        private SaleDBContext context;
        public SaleController(SaleDBContext context)
        {
            this.context = context;
        }

        public IActionResult index() {

            return View();
        }
     
        [HttpPost(Name = "AddSale")]
        public IActionResult AddSale([FromBody] SaleMaster _saleMaster) {
            if (_saleMaster == null)
                return BadRequest();
            this.context.Add(_saleMaster);
            this.context.SaveChanges();
            return CreatedAtRoute("GetSales",null);
            
        }

        [HttpGet(Name = "GetSales")]
        public IActionResult GetSales()
        {
            var _saleMaster = context.SaleMasters.Include(p => p.ProductSaleJoins);
            if (!_saleMaster.Any())
                return NotFound();
            return Ok(this.context.SaleMasters);

        }

        
        
    }
}
