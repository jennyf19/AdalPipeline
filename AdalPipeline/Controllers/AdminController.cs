using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdalPipeline.Models;


namespace AdalPipeline.Controllers
{
    public class AdminController : Controller
    {
        [HttpPost]
        public ViewResult Checkout(Request request)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                return View();
            }
        }
    }
}