using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        
        public ViewResult ApproveRelease(Request request)
        {
            return View("ApproveRelease", request);
        }

        /*public ActionResult ApproveRelease(Request request)
        {
            return View("ApproveRelease");
        }*/

        public ActionResult LoadProducts()
        {
            List<SelectListItem> productList = new List<SelectListItem>();
            productList.Add(new SelectListItem { Text = "Select", Value = "0" });
            productList.Add(new SelectListItem { Text = "Adal-v4", Value = "1" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-android-convergence", Value = "2" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-dotnet-v2", Value = "3" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-dotnet-v3", Value = "4" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-java", Value = "5" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-js-dev", Value = "6" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-js-master", Value = "7" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-nodejs-master", Value = "8" });
            productList.Add(new SelectListItem { Text = "Azure-activedirectory-library-for-objc-dev", Value = "9" });
            productList.Add(new SelectListItem { Text = "build-android-master", Value = "10" });
            productList.Add(new SelectListItem { Text = "gradle-build-android-master", Value = "11" });
            productList.Add(new SelectListItem { Text = "msal-dotnet", Value = "12" });
            productList.Add(new SelectListItem { Text = "NativeADAL", Value = "13" });
            productList.Add(new SelectListItem { Text = "WilsonForDotNet45Dev", Value = "14" });
            productList.Add(new SelectListItem { Text = "WilsonForDotNet45Release", Value = "15" });
            productList.Add(new SelectListItem { Text = "WilsonForKDev", Value = "16" });
            productList.Add(new SelectListItem { Text = "WilsonForKMaster", Value = "17" });
            productList.Add(new SelectListItem { Text = "WilsonForKRelease", Value = "18" });
            ViewData["product"] = productList;
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

        public ActionResult Completed()
        {
            return View("Completed");
        }
    }
}