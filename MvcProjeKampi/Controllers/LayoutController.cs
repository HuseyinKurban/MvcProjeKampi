﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult HeadPartial()
        {
            return PartialView();
        }
        public ActionResult SidebarPartial()
        {
            var p = (string)Session["AdminUserName"];
            ViewBag.isim = p;
            return PartialView();
        }
        public ActionResult ScriptPartial()
        {
            return PartialView();
        }
        public ActionResult LogoPartial()
        {
            return PartialView();
        }
    }
}