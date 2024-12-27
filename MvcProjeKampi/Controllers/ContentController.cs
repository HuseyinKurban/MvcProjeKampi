using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContent()
        {
            string p = "";
            // Context c = new Context();
            // var values = from x in c.Contents select x;
            //// eğerki p değeri boş değilse
            // if (!string.IsNullOrEmpty(p))
            // {
            //   //  parametre boş değilse valuese atama yap
            //     values = values.Where(y => y.ContentValue.Contains(p));
            // }

            // var values = c.Contents.ToList();


            var values = cm.GetList(p);
            return View(values);


        }

        public ActionResult ContentByHeading(int id)
        {
            var values = cm.GetListByHeadingID(id);
            return View(values);
        }
    }
}