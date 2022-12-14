using Microsoft.AspNetCore.Mvc;
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
            if (post.Content.Length > 300)
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
        [Route("update-post")]
        public IActionResult UpdatePost([FromBody] Post post)
        {
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
    }
}
