using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;


namespace SalesApp.Controllers
{
    using Sales.Data.Interfaces;
    using SalesApp.Model;
    using System.Threading.Tasks;
    [Route("api/[controller]/[action]")]
    [EnableCors("CorsPolicy")]
    public class SaleController : Controller
    {
        private ISale ISale;
        public SaleController(ISale _ISale)
        {
            this.ISale = _ISale;
        }

     
        [HttpPost(Name = "AddSale")]
        public IActionResult AddSale([FromBody] SaleMaster _saleMaster) {
                return BadRequest();
        }

        [HttpGet(Name = "GetSales")]
        public  IActionResult GetSales()
        {
            Task<IEnumerable<SaleMaster>> _TsaleMaster = this.ISale.GetSalesAsync();
             return new OkObjectResult(Result);
        }
        
    }
}
