using System;

namespace DAL.Entities
{
    public class Comment
    {
        public int commentId { get; set; }
        public string authorName { get; set; }
        public DateTime Date { get; set; }
        public string commentContent { get; set; }
    }
}
