﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm=new ContentManager(new EfContentDal());


        public ActionResult Headings()
        {
            var values = hm.GetList();
            return View(values);

           
        }

        public PartialViewResult Index(int id=0)
        {
            var value=cm.GetListByHeadingID(id);
            return PartialView(value);
        }
    }
}