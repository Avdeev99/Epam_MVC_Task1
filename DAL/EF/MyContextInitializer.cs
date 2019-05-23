using DAL.Entities;
using System;
using System.Data.Entity;

namespace DAL.EF
{
    class MyContextInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            Article a1 = new Article
            {
                articleId = 1,
                Name = "Английский перевод 1914 года, H. Rackham",
                Content = "But I must explain to you how all this mistaken idea of denouncing pleasure " +
                "and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of " +
                "human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter " +
                "consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally " +
                "circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except " +
                "to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain " +
                "that produces no resultant pleasure?",
                Date = DateTime.Now
            };
            Article a2 = new Article
            {
                articleId = 2,
                Name = "Английский перевод 1914 года, H. Rackham",
                Content = "But I must explain to you how all this mistaken idea of denouncing pleasure " +
                "and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of " +
                "human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter " +
                "consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally " +
                "circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except " +
                "to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain " +
                "that produces no resultant pleasure?",
                Date = DateTime.Now
            };
            Article a3 = new Article
            {
                articleId = 3,
                Name = "Английский перевод 1914 года, H. Rackham",
                Content = "But I must explain to you how all this mistaken idea of denouncing pleasure " +
                "and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of " +
                "human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter " +
                "consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally " +
                "circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except " +
                "to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain " +
                "that produces no resultant pleasure?",
                Date = DateTime.Now
            };
            Article a4 = new Article
            {
                articleId = 4,
                Name = "Английский перевод 1914 года, H. Rackham",
                Content = "But I must explain to you how all this mistaken idea of denouncing pleasure " +
                "and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of " +
                "human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter " +
                "consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally " +
                "circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except " +
                "to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain " +
                "that produces no resultant pleasure?",
                Date = DateTime.Now
            };

            db.Articles.Add(a1);
            db.Articles.Add(a2);
            db.Articles.Add(a3);
            db.Articles.Add(a4);


            Comment c1 = new Comment { authorName = "Александр Иванов", Date = DateTime.Now, commentContent = "Супер!!!!!!!!!!!", commentId = 1 };
            Comment c2 = new Comment { authorName = "Петр Петров", Date = DateTime.Now, commentContent = "Прикольно!!!!!!!!!!!", commentId = 2 };
            Comment c3 = new Comment { authorName = "Алексей Леонтьев", Date = DateTime.Now, commentContent = "Отлично!!!!!!!!!!!", commentId = 3 };
            Comment c4 = new Comment { authorName = "Василий Иванов", Date = DateTime.Now, commentContent = "Класс!!!!!!!!!!!", commentId = 4 };
            Comment c5 = new Comment { authorName = "Алексей Иванов", Date = DateTime.Now, commentContent = "Невероятно!!!!!!!!!!", commentId = 5 };
            Comment c6 = new Comment { authorName = "Петр Алексеев", Date = DateTime.Now, commentContent = "Невероятно!!!!!!!!!!", commentId = 6 };

            db.Comments.Add(c1);
            db.Comments.Add(c2);
            db.Comments.Add(c3);
            db.Comments.Add(c4);
            db.Comments.Add(c5);
            db.Comments.Add(c6);

            db.SaveChanges();
        }
    }
}
