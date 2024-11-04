using HallManagment.Entities;
using HallManagment.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HallManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CateringController : ControllerBase
    {
        CateringServes ctr = new CateringServes();


        // GET: api/<CateringController>
        [HttpGet]
        public List<Catering> Get()
        {
            return ctr.GetCaterings();
        }

        // GET api/<CateringController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Catering? c=ctr.GetCateringById(id);
            if(c == null)
                return NotFound();
            return Ok(c);
        }

        // POST api/<CateringController>
        [HttpPost]
        public void Post([FromBody] Catering catering)
        {
            ctr.AddCatering(catering);
        }

        // PUT api/<CateringController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Catering catering)
        {
            ctr.UpdateCatering(id, catering);
        }

        // DELETE api/<CateringController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ctr.DeleteCatering(id);
        }
    }
}
