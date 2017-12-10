using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_mug_stock.Models;
using Microsoft.AspNetCore.Mvc;

namespace back_mug_stock.Controllers
{
    [Route("api/[controller]")]
    public class StockController : Controller
    {
        private readonly StockContext _context = null;

        public StockController(StockContext context){
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            return _context.Stocks.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Stock Get(int id)
        {
            return _context.Stocks.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Stock value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Stock value)
        {
            Stock stock = _context.Stocks.Find(id);
            stock.Name = value.Name;
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Stock stock = _context.Stocks.Find(id);
            _context.Stocks.Remove(stock);
            _context.SaveChanges();
        }
    }
}
