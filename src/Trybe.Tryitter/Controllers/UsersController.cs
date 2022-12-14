using Microsoft.AspNetCore.Mvc;
using Trybe.Tryitter.Models;
using Trybe.Tryitter.Repository;

namespace Trybe.Tryitter.Controllers
{
    
    [Route("trybe-tryitter/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _usersRepository;

        public UsersController(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet("get-user-by-id/{id}")]
        public IActionResult GetUserById(int id) 
        {
            var result = _usersRepository.GetUserById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("add-user")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var add = _usersRepository.AddUser(user);
            return Ok(add);
        }

        [HttpGet("get-user")]
        public IActionResult GetUser()
        {
            return Ok(_usersRepository.GetUsers());
        }

        [HttpPut("update-user")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            _usersRepository.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("delete-user/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var result = _usersRepository.DeleteUser(id);
            if (result == false)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
