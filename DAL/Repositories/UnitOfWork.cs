using DAL.EF;
using System;

namespace DAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private BlogContext db;
        private ArticleRepository articleRepository;
        private CommentRepository commentRepository;

        public UnitOfWork()
        {
            db = new BlogContext();
        }

        public ArticleRepository Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(db);
                return articleRepository;
            }
        }
        public CommentRepository Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            this.db.SaveChanges();
        }
    }
}
