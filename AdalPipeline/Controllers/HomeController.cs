using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdalPipeline.Models;

namespace AdalPipeline.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateRequest()
        {
            return View(new Request());
        }

        [HttpPost]
        public ActionResult CreateRequest(Request request)
        {
            return View("DisplayRequest", request);
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
    }
}