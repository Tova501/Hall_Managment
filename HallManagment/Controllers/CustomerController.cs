using HallManagment.Entities;
using HallManagment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HallManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerServes cst=new CustomerServes();

        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(cst.GetCustomers());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Customer? c= cst.GetCustomerById(id);
            if(c == null)
                return NotFound();
            return Ok(c);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            cst.AddCustomer(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            cst.UpdateCustomer(id, customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            cst.RemoveCustomer(id);
        }
    }
}
