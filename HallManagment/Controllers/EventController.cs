using HallManagment.Entities;
using HallManagment.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HallManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        EventServes evt=new EventServes();

        // GET: api/<EventController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(evt.GetEvents());
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Event e = evt.GetEventById(id);
            if(e==null)
                return NotFound();
            return Ok(e);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event e)
        {
            evt.AddEvent(e);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event e)
        {
            evt.UpdateEvent(id, e);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            evt.DeleteEvent(id);
        }

        // GET: api/<EventController>
        [HttpGet("/open")]
        public ActionResult GetOpenEvents(bool open)
        {
            return Ok(evt.GetOpenEvents());
        }

        [HttpGet("/date={date}")]
    }
}
