using DataAccessLayer.Concrete;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
               
        }

        //değer ataması yapıyoruz  
        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            Context c=new Context();

            ct=c.Categories.Select(x=>new CategoryClass
            {
                CategoryName = x.CategoryName,
                CategoryCount=x.Headings.Count()
            }).ToList();
            return ct;

            //ct.Add(new CategoryClass()
            //{
            //    CategoryName = "Yazılım",
            //    CategoryCount = 20
            //});

            //ct.Add(new CategoryClass()
            //{
            //    CategoryName = "Seyahat",
            //    CategoryCount = 4
            //});

            //ct.Add(new CategoryClass()
            //{
            //    CategoryName = "Spor",
            //    CategoryCount = 47
            //});

           
        }
    }
}