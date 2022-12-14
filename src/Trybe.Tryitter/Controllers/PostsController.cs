using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Trybe.Tryitter.Models;
using Trybe.Tryitter.Repository;

namespace Trybe.Tryitter.Controllers
{
    [ApiController]
    [Route("trybe-tryitter/posts")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _repository;

        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("get-posts")]
        public IActionResult GetPosts() 
        {
            var result = _repository.GetAllPosts();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-post-by-id/{id}")]
        public IActionResult GetPostById(int id) 
        {
            var result = _repository.GetPostById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("add-post")]
        public IActionResult AddPost([FromBody] Post post)
        {
            if (post?.Content.Length > 300)
            {
                return BadRequest("Mensagem ultrapassou 300 caracteres");
            };
            
            var result = _repository.AddPost(post);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);

        }

        [HttpPatch]
        //[Authorize]
        [Route("update-post")]
        public IActionResult UpdatePost([FromBody] Post post)
        {
            //var claims = HttpContext.User.Identity as ClaimsIdentity;
            //var getId = claims.FindFirst("Id").Value;

            //if(Convert.ToInt32(getId) != post.UserId)
            //{
            //    return BadRequest();
            //};

            _repository.UpdatePost(post);
            return Ok();
        }

        [HttpDelete]
        [Route("delete-post/{id}")]
        public IActionResult DeletePost(int id)
        {
            var result = _repository.DeletePost(id);
            if (result == false)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet]
        [Route("get-all-user-posts/{userId}")]
        public IActionResult GetAllUserPosts(int userId)
        {
            var result = _repository.GetAllUserPosts(userId);
            return Ok(result);

        }

        [HttpGet]
        [Route("get-last-post/{userId}")]
        public IActionResult GetLastPost(int userId)
        {
            var result = _repository.GetLastPost(userId);
            return Ok(result);
        }
    }
}
