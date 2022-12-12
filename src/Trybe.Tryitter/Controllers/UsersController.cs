using Microsoft.AspNetCore.Mvc;
using Trybe.Tryitter.Models;
using Trybe.Tryitter.Repository;

namespace Trybe.Tryitter.Controllers
{
    [ApiController]
    [Route("trybe-tryitter")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _usersRepository;

        public UsersController(IUserRepository usersRepository)
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
