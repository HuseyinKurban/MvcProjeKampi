﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager mm = new MessageManager(new EfMessageDal());

        public ActionResult Inbox()
        {
            var values = mm.GetListInbox();
            return View(values);
        }

        public ActionResult Sendbox()
        {
            var values = mm.GetListSendbox();
            return View(values);
        }

    }
}