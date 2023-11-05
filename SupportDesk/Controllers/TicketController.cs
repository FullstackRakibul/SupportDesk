using Microsoft.AspNetCore.Mvc;
using SupportDesk.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SupportDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        // GET: api/<TicketController>
        [HttpGet]
        [HttpGet]
        public IEnumerable<Ticket> GetTicketss()
        {
            return TicketRepository.Tickets;
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public Ticket GetTicketId(int id)
        {
            return TicketRepository.Tickets.FirstOrDefault(n => n.TicketId == id);
        }


        // POST api/<TicketController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
