﻿namespace Trybe.Tryitter.Models
{
    public class Posts
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}