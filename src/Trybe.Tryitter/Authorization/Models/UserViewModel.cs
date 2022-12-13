using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Authorization.Models
{
    public class UserViewModel
    {
        public User? User { get; set; }
        public string? Token { get; set; }
    }
}
