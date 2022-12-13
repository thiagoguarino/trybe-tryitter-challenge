using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trybe.Tryitter.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
    }
}
