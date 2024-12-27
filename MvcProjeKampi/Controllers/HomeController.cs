using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
      
        Context c = new Context();
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

        public PartialViewResult HomePageGallery()
        {
            var values=c.ImageFiles.ToList();
            return PartialView(values);
        }

        public PartialViewResult HomePageStats()
        {

            ViewBag.totalheadings = c.Headings.Count();
            ViewBag.totalcontents = c.Contents.Count();
            ViewBag.totalwriters = c.Writers.Count();
            ViewBag.totalmessages = c.Messages.Count();

            return PartialView();
        }

        public PartialViewResult HomePageTestimonials()
        {
           var values=c.Contents.OrderByDescending(x=>x.WriterID).Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult HomePageContact()
        {
            
            return PartialView();
        }

        public PartialViewResult HomePageFooter()
        {

            return PartialView();
        }

        public PartialViewResult HomePageScript()
        {
            return PartialView();
        }

        public PartialViewResult HomePageExperience()
        {
            return PartialView();
        }

        public PartialViewResult HomePageLoginAndRegister()
        {
            return PartialView();
        }


    }
}