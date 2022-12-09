using Microsoft.AspNetCore.Mvc;
using Trybe.Tryitter.Models;
using Trybe.Tryitter.Repository;

namespace Trybe.Tryitter.Controllers
{
    [ApiController]
    [Route("trybe-tryitter")]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _usersRepository;

        public UsersController(UserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost]
        [Route("add-user")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var add = _usersRepository.AddUser(user);
            return Ok(add);

        }

    }
}
