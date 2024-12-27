using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{

    public class AuthorizationController : Controller
    {
        // GET: Authorization
        AdminManager adminmanager = new AdminManager(new EfAdminDal());

        public ActionResult Index()
        {
            var values = adminmanager.GetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminmanager.AdminAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var value=adminmanager.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminmanager.AdminUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult AdminDelete(int id)
        {
            var p=adminmanager.GetByID(id);
            adminmanager.AdminDelete(p);
            return RedirectToAction("Index");
        }
    }
}