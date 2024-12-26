using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        ContentManager cm = new ContentManager(new EfContentDal());
      

        public ActionResult MyContent(string p)
        {
            // Session kontrolü
            p = (string)Session["WriterMail"];
            if (string.IsNullOrEmpty(p)) // Eğer Session'da mail yoksa
            {
                return RedirectToAction("WriterLogin", "Login");
            }

            // id kontrolü
            var writeridinfo = cm.GetWriterIdByMail(p) ?? 0;
            if (writeridinfo == 0) // Eğer Writer ID bulunamazsa
            {
                return RedirectToAction("WriterLogin", "Login");
            }

            
            var values = cm.GetListByWriterID(writeridinfo);
            return View(values);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d=id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content p)
        {
           
            string mail = (string)Session["WriterMail"];
            var writeridinfo = cm.GetWriterIdByMail(mail);

            
            p.ContentDate = DateTime.Now;
            p.WriterID = writeridinfo;
            p.ContentStatus = true;
            cm.ContentAdd(p);
            return RedirectToAction("MyContent");
        }



    }
}