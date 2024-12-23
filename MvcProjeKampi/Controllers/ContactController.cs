using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
        ContactValidator cv = new ContactValidator();

        public ActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }

        public ActionResult GetContactDetails(int id)
        {
            var values=cm.GetByID(id);
            return View(values);
        }

        public PartialViewResult MessageFolders()
        {
            return PartialView();
        }

    }
}