using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
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

        public ActionResult HomePage()
        {
            return View();
        }

        public PartialViewResult HomePageHead()
        {
            return PartialView();
        }

        public PartialViewResult HomePageNavbar()
        {
            return PartialView();
        }

        public PartialViewResult HomePageHeader()
        {
            return PartialView();
        }

        public PartialViewResult HomePageTechnology()
        {
            return PartialView();
        }

        public PartialViewResult HomePageServices()
        {
            return PartialView();
        }

    }
}