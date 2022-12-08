using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_usersRepository.GetUser());

        }

    }
}
