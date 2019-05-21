using EpamMVCPractice1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpamMVCPractice1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Articles = new List<Article> { new Article { articleId = 1, Name = "Английский перевод 1914 года, H. Rackham", Content = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?", Date = DateTime.Now},
             new Article { articleId = 2, Name = "Английский перевод 1914 года, H. Rackham", Content = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?", Date = DateTime.Now},
            new Article { articleId = 1, Name = "Английский перевод 1914 года, H. Rackham", Content = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?", Date = DateTime.Now},
            new Article { articleId = 1, Name = "Английский перевод 1914 года, H. Rackham", Content = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?", Date = DateTime.Now}
            };
            return View();
        }

        public ActionResult Guest()
        {
            ViewBag.List = new List<Comment> { new Comment { authorName = "Александр Иванов", Date = DateTime.Now, commentContent = "Супер!!!!!!!!!!!", commentId = 1 },
            new Comment { authorName = "Петр Петров", Date = DateTime.Now, commentContent = "Прикольно!!!!!!!!!!!", commentId = 2},
            new Comment { authorName = "Алексей Леонтьев", Date = DateTime.Now, commentContent = "Отлично!!!!!!!!!!!", commentId = 3},
            new Comment { authorName = "Василий Иванов", Date = DateTime.Now, commentContent = "Класс!!!!!!!!!!!", commentId = 4},
            new Comment { authorName = "Алексей Иванов", Date = DateTime.Now, commentContent = "Невероятно!!!!!!!!!!", commentId = 5},
             new Comment { authorName = "Петр Алексеев", Date = DateTime.Now, commentContent = "Невероятно!!!!!!!!!!", commentId = 6}};
            return View();
        }

        [HttpPost]
        public ActionResult Guest(string com)
        {
            return View("ThanksForComment", (object)com);
        }
        
        


        
        public ActionResult Form(string Name, string Surname, string sex, IEnumerable<string> favsport)
        {
            if ("GET" == this.HttpContext.Request.RequestType)
            {
                return View();
            }
            else if ("POST" == this.HttpContext.Request.RequestType)
            {
                ViewBag.Name = Name;
                ViewBag.Surname = Surname;
                ViewBag.sex = sex;
                ViewBag.sports = favsport;
                return View("TestResult");
            }
            return View();
        }


    }
}