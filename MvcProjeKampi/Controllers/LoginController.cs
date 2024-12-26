using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using MvcProjeKampi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        AdminManager adminmanager = new AdminManager(new EfAdminDal());
        WriterManager writermanager = new WriterManager(new EfWriterDal());

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {

            var adminuserinfo = adminmanager.GetAdmin(admin.AdminUserName, admin.AdminPassword);

            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserinfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult WriterLogin()
        {

            return View();
        }

        [HttpPost]
        public ActionResult WriterLogin(Writer writer)
        {
            var response = Request["g-recaptcha-response"];
            const string secret = "6Leu7aUqAAAAANoUhBidsDmRvWWZGETubEH-B70h";

            var client = new WebClient();
            var reply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));

            var captchaResponse = JsonConvert.DeserializeObject<ReCaptcha>(reply);

            

            if (captchaResponse.Success)
            {
                var writeruserinfo = writermanager.GetWriter(writer.WriterMail, writer.WriterPassword);

                if(writeruserinfo != null)
                {
                    FormsAuthentication.SetAuthCookie(writeruserinfo.WriterMail, false);
                    Session["WriterMail"] = writeruserinfo.WriterMail;
                    return RedirectToAction("WriterProfile", "WriterPanel");
                }

                else
                {
                    ViewBag.hataMesaj = "Geçersiz e - posta adresi veya şifre.";
                    return View();
                }

            }
            else
            {
                ViewBag.hataMesaj = "Lütfen güvenliği doğrulayınız";
                return View();
            }
        }
    }
}