using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        Context c = new Context();

        public ActionResult Index()
        {
            var deger1 = c.Categories.Count().ToString();
            ViewBag.d1 = deger1;

            var categoryId = c.Categories.Where(x => x.CategoryName == "yazılım").Select(x =>x.CategoryID).FirstOrDefault();
            var deger2 = c.Headings.Where(x => x.CategoryID == categoryId).Count();
            ViewBag.d2 = deger2;

            var deger3 = c.Writers.Where(x => x.WriterName.Contains("a")).Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Categories.Where(x => x.CategoryID == (c.Headings.GroupBy(y => y.CategoryID).OrderByDescending(y => y.Count()).Select(y => y.Key).FirstOrDefault())).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.d4 = deger4;

            var deger5 = c.Categories.Where(x => x.CategoryStatus == true).Count() - c.Categories.Where(x => x.CategoryStatus == false).Count();
            ViewBag.d5 = deger5;
            return View();
        }
    }
}