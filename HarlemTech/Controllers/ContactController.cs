using HarlemTech.DataAccess.Helpers;
using HarlemTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarlemTech.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Submit(ContactModel model)
        {
            EmailHelper.SendEmail(model.Name, model.Email, model.Comment);

            return RedirectToAction("Thanks");
        }

        [HttpGet]
        public ActionResult Thanks()
        {
            return View();
        }
    }
}