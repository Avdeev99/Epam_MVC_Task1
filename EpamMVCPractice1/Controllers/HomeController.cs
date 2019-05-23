
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Net;
using System.Web.Mvc;

namespace EpamMVCPractice1.Controllers
{
    public class HomeController : Controller
    {


        /// <summary>
        /// This method returns Main page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                ViewBag.Articles = unitOfWork.Articles.GetAll();
                return View();
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("EditArticle");
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                article.Date = DateTime.UtcNow;
                unitOfWork.Articles.Create(article);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var unitOfWork = new UnitOfWork())
            {
                Article article = unitOfWork.Articles.Get(id);

                if (article == null)
                {
                    return HttpNotFound();
                }
                return View("EditArticle", article);
            }
        }

        [HttpPost]
        public ActionResult Update(Article article)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Articles.Edit(article);

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var unitOfWork = new UnitOfWork())
            {
                Article article = unitOfWork.Articles.Get(id);

                if (article == null)
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Articles.Delete(id);
                return RedirectToAction("Index");
            }
        }

    }
}