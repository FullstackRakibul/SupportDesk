using Microsoft.AspNetCore.Mvc;
using SupportDesk.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SupportDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return UserRepository.Users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return UserRepository.Users.FirstOrDefault(n => n.UserId == id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
