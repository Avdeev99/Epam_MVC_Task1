using DAL.EF;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CommentRepository
    {
        BlogContext db;

        public CommentRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        public IEnumerable<Comment> GetAll()
        {
            return this.db.Comments.ToList();
        }
    }
}
