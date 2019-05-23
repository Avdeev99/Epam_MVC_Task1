using System;

namespace DAL.Entities
{
    public class Article
    {
        public int articleId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
