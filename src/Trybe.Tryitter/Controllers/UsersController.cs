using Microsoft.AspNetCore.Mvc;
using Trybe.Tryitter.Models;
using Trybe.Tryitter.Repository;

namespace Trybe.Tryitter.Controllers
{
    public class UsersController : ControllerBase
    {
        private readonly UsersRepository _usersRepository;

        public UsersController(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] Users user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            _usersRepository.AddUser(user);
            return CreatedAtAction("Get", new { id = user.Id }, user);

        }

    }
}
