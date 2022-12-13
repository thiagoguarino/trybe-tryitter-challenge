using System.Diagnostics.Contracts;
using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public interface IPostRepository
    {
        public Post? AddPost(Post post);
        public Post? GetPostById(int id);
        public IEnumerable<Post> GetAllPosts();
        public void UpdatePost(Post post);
        public bool DeletePost(int id);
    }
}
