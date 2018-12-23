using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PoPUpModal.Models;

namespace PoPUpModal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [HandleError]
        public ActionResult SaveBlog(Blog model)
        {
            if (ModelState.IsValid)
            {
                // Save it in database

                //Return Success message
                ViewBag.Message = "Blog saved";
                ModelState.Clear();
                return PartialView("_Blog");
            }
            return PartialView("_Blog", model);
        }
    }
}