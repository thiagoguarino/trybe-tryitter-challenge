using Microsoft.Extensions.Hosting;
using Trybe.Tryitter.Models;
using Microsoft.EntityFrameworkCore;

namespace Trybe.Tryitter.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly IMyContext _context;

        public PostRepository(IMyContext context)
        {
            _context = context;
        }

        public Post? AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return _context.Posts.Find(post?.PostId);
        }

        public Post? GetPostById(int postId)
        {
            return _context.Posts.FirstOrDefault(x => x.PostId == postId);           
        }

        public IEnumerable<Post> GetAllPosts() 
        {
            return _context.Posts.ToList();
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Entry(post).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool DeletePost(int postId)
        {
            var current = _context.Posts.Find(postId);
            if (current == null) 
            {
                return false;
            }
            _context.Posts.Remove(current);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Post> GetAllUserPosts(int userId)
        {
            return _context.Posts.Where(x => x.UserId == userId).ToList();
        }

        public Post GetLastPost(int userId)
        {
            return _context.Posts.Where(x => x.UserId == userId).ToList().Last();
        }
    }
}
