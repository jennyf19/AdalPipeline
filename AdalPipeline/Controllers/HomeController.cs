using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (string.IsNullOrEmpty(request.ReleaseTitle))
            {
                ModelState.AddModelError("ReleaseTitle", "Please enter a title for the release");
            }

            if (string.IsNullOrEmpty(request.ReleaseVersion) || !Regex.IsMatch(request.ReleaseVersion, @"^v[1-9]{1,2}\.([0-9]{1,2}\.)([0-9]{1,3})$"))
            {
                ModelState.AddModelError("ReleaseVersion", "The Version number needs to be in semantic versioning (vx.xx.xxx)");
            }

            if (string.IsNullOrEmpty(request.ReleaseNotes))
            {
                ModelState.AddModelError("ReleaseNotes", "Please include Release Notes for the product");
            }

            if (ModelState.IsValid)
            {
                return View("DisplayRequest", request);
            }
            return View();
        }

        public ActionResult ApproveRequest(Request request)
        {
           //ViewData["ReleaseTitle"] = request.ReleaseTitle;
            //ViewData["ReleaseVersion"] = request.ReleaseVersion;
            //ViewData["ReleaseNotes"] = request.ReleaseNotes;

            return View("ApproveRequest");
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