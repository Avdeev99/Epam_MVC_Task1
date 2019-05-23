using DAL.Entities;
using System.Data.Entity;

namespace DAL.EF
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(new MyContextInitializer());
        }
    }
}
