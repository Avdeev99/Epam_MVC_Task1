using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCPractice1.Models
{
    public class Article
    {
        public int articleId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}