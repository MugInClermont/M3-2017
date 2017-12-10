using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using back_mug_invoice.Models;

namespace back_mug_invoice.Controllers
{
    [Route("api/[controller]")]
    public class InvoiceController : Controller
    {
        private readonly InvoiceContext _context = null;

        public InvoiceController(InvoiceContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            return _context.Invoices.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Invoice Get(int id)
        {
            return _context.Invoices.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Invoice value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Invoice value)
        {
            Invoice invoice = _context.Invoices.Find(id);
            if (invoice != null)
            {
                invoice.Name = value.Name;
                _context.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Invoice invoice = _context.Invoices.Find(id);
            _context.Invoices.Remove(invoice);
            _context.SaveChanges();
        }
    }
}
