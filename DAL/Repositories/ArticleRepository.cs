using DAL.EF;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repositories
{
    public class ArticleRepository
    {
        BlogContext db;

        public ArticleRepository(BlogContext context)
        {
            this.db = context;
        }

        public void Create(Article article)
        {
            article.Date = DateTime.Now;
            db.Articles.Add(article);
            db.SaveChanges();
        }

        public void Edit(Article article)
        {
            db.Entry(article).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int? id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
        }

        public Article Get(int? id)
        {
            return this.db.Articles.Find(id);
        }

        public IEnumerable<Article> GetAll()
        {
            return this.db.Articles.ToList();
        }

    }
}
