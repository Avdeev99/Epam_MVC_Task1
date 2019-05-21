using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCPractice1.Models
{
    public class Comment
    {
        public int commentId { get; set; }
        public string authorName { get; set; }
        public DateTime Date { get; set; }
        public string commentContent { get; set; }
    }
}