using DAL.Entities;
using DAL.Repositories;
using System;
using System.Web.Mvc;

namespace EpamMVCPractice1.Controllers
{
    public class CommentController : Controller
    {

        /// <summary>
        /// This method returns Guest page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                ViewBag.List = unitOfWork.Comments.GetAll();
                return View("Guest");
            }
        }

        [HttpPost]
        public ActionResult Guest(string authorName, string com)
        {
            Comment c = new Comment { authorName = authorName, commentContent = com, Date = DateTime.Now };

            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Comments.Create(c);
                ViewBag.List = unitOfWork.Comments.GetAll();
                return RedirectToAction("Index");
            }
        }
    }
}