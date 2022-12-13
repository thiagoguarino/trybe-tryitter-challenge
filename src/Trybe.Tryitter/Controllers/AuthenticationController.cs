using Microsoft.AspNetCore.Mvc;
using Trybe.Tryitter.Authorization.Models;
using Trybe.Tryitter.Repository;
using Trybe.Tryitter.Authorization;
using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Controllers
{
    [ApiController]
    [Route("login")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public AuthenticationController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<UserViewModel> Authenticate([FromBody] User user)
        {
            UserViewModel userViewModel = new UserViewModel();
            try
            {
                userViewModel.User = _repository.GetUser(user);
                if (userViewModel.User == null) 
                {
                    return NotFound("User not found!");
                }
                userViewModel.Token = new TokenGenerator().Generate(user);
                userViewModel.User.Password = string.Empty;
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return userViewModel;

        }

    }
}
