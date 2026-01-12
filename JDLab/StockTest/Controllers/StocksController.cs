using Microsoft.AspNetCore.Mvc;
using StockTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        // GET: api/<StocksController>
        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            List<Stock> list = new List<Stock>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Stock() 
                {
                  ID = i + 1,
                  Company = "Company " + (i + 1), 
                  Value = new Random().Next(1, 1000)
                });
            }
            return list;
        }

    }
}
