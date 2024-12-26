using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactValidator cv = new ContactValidator();


        public ActionResult Index()
        {

            var values = cm.GetList();
            return View(values);
        }

        public ActionResult GetContactDetails(int id)
        {
            var values = cm.GetByID(id);
            return View(values);
        }

        public PartialViewResult MessageFolders()
        {
            string mail = (string)Session["AdminUserName"];

            if (mail != null)
            {
                var values = mm.GetListInbox(mail);
                var values2 = mm.GetListSendbox(mail);
                var values3 = cm.GetList();
                ViewBag.gelenadmin = values.Count();
                ViewBag.gonderilenadmin = values2.Count();
                ViewBag.iletisimadmin=values3.Count();
            }
            else
            {
                ViewBag.gelenadmin = 0;
                ViewBag.gonderilenadmin = 0;
                ViewBag.iletisimadmin = 0;
            }

            return PartialView();
        }

    }
}