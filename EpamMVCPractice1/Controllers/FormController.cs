using System.Collections.Generic;
using System.Web.Mvc;

namespace EpamMVCPractice1.Controllers
{
    public class FormController : Controller
    {
        /// <summary>
        /// This method returns View on GET request and returns result on POST request
        /// </summary>
        /// <param name="Name">Name</param>
        /// <param name="Surname">Surname</param>
        /// <param name="sex">Sex</param>
        /// <param name="favsport">List of favorite sports</param>
        /// <returns></returns>
        public ActionResult Index(string Name, string Surname, string sex, IEnumerable<string> favsport)
        {
            if (this.HttpContext.Request.RequestType == "GET")
            {
                return View("Form");
            }
            else if (this.HttpContext.Request.RequestType == "POST")
            {
                ViewBag.Name = Name;
                ViewBag.Surname = Surname;
                ViewBag.sex = sex;
                ViewBag.sports = favsport;
                return View("TestResult");
            }
            return View("Form");
        }
    }
}