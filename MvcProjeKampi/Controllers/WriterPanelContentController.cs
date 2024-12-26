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



    }
}