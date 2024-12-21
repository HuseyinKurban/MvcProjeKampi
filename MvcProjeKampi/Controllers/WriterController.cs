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
    public class WriterController : Controller
    {
        // GET: Writer
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writerValidator = new WriterValidator();

        public ActionResult Index()
        {
            var values=wm.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
          
            ValidationResult result= writerValidator.Validate(p);

            if (result.IsValid)
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
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

        [HttpGet]
        public ActionResult UpdateWriter(int id)
        {
            var values=wm.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateWriter(Writer p)
        {
            
            ValidationResult result = writerValidator.Validate(p);

            if (result.IsValid)
            {
                wm.WriterUpdate(p);
                return RedirectToAction("Index");
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