using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using BusinessLayer.ValidationRules_Fluent;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{

    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writerValidator = new WriterValidator();
        Context c = new Context();

        [HttpGet]
        public ActionResult WriterProfile()
        {

            int id = 0;
            string p = (string)Session["WriterMail"];

            if (p != null)
            {
              
                id = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();

              
                var writervalue = wm.GetByID(id);

                // Yazar bilgilerini View'a gönder
                return View(writervalue);
            }
            else
            {
                
                return RedirectToAction("WriterLogin", "Login");
            }


            //string p = (string)Session["WriterMail"];

            //if (p != null)
            //{
            //    var values = hm.GetWriterIdByMail(p);
            //    ViewBag.d = values;
            //    return View(values);
            //}
            //else
            //{
            //    return RedirectToAction("WriterLogin","Login");
            //}
            //

        }

        [HttpPost]
        public ActionResult WriterProfile(Writer p)
        {

            ValidationResult result = writerValidator.Validate(p);

            if (result.IsValid)
            {

                wm.WriterUpdate(p);
                Session["WriterMail"] = p.WriterMail;
                return RedirectToAction("WriterProfile");
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

        public ActionResult MyHeading(string p)
        {

            //var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault(); bunun yerine katmanlı mimariye tasıdım

            p = (string)Session["WriterMail"];
            var writeridinfo = hm.GetWriterIdByMail(p);
            var values = hm.GetListByWriter(writeridinfo, true);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }

        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            var d = (string)Session["WriterMail"];
            var writeridinfo = hm.GetWriterIdByMail(d);

            p.WriterID = writeridinfo;
            p.HeadingDate = DateTime.Now;
            p.HeadingStatus = true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;

            var value = hm.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            var value = hm.GetByID(id);
            value.HeadingStatus = false;
            hm.HeadingDelete(value);
            return RedirectToAction("MyHeading");

        }

        public ActionResult AllHeading(int p = 1)
        {
            var head = hm.GetList().ToPagedList(p, 5);
            return View(head);
        }



    }
}