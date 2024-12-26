using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_Fluent;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();

        public PartialViewResult MessageListMenu()
        {
            string mail = (string)Session["WriterMail"];
            ViewBag.gelen = mm.GetListInbox(mail).Count();
            ViewBag.giden = mm.GetListSendbox(mail).Count();

            return PartialView();
        }

        public ActionResult Inbox()
        {
            string mail = (string)Session["WriterMail"];

            if (mail != null)
            {
                var values = mm.GetListInbox(mail);
                return View(values);
            }
            else
            { return RedirectToAction("WriterLogin", "Login"); }
        }

        public ActionResult Sendbox()
        {
            string mail = (string)Session["WriterMail"];

            if (mail != null)
            {
                var values = mm.GetListSendbox(mail);
                return View(values);
            }
            else
            { return RedirectToAction("WriterLogin", "Login"); }

        }

        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            string mail = (string)Session["WriterMail"];

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult NewMessage(Message p)
        {
            string mail = (string)Session["WriterMail"];
            ValidationResult result = messagevalidator.Validate(p);
            if (result.IsValid)
            {
                p.SenderMail = mail;
                p.MessageDate = DateTime.Now;
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}