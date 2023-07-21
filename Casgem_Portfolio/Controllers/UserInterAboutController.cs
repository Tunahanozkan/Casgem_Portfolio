using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class UserInterAboutController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        // GET: UserInterAbout
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult BreadcrumbPartial()
        {
            return PartialView();
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.tbl_socialmedya.ToList();


            ViewBag.Name = db.tbl_about.Select(x => x.Name).FirstOrDefault();
            ViewBag.Surname = db.tbl_about.Select(x => x.Surname).FirstOrDefault();
            ViewBag.Address = db.tbl_about.Select(x => x.Address).FirstOrDefault();
            ViewBag.Des = db.tbl_about.Select(x => x.Des).FirstOrDefault();
            ViewBag.PhoneNumber = db.tbl_about.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.ImageUrl = db.tbl_about.Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.Mail = db.tbl_about.Select(x => x.Mail).FirstOrDefault();

            return PartialView(values);
        }
        public PartialViewResult About2Partial()
        {
            return PartialView();
        }
        public PartialViewResult About3Partial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterScript()
        {
            var values = db.tbl_socialmedya.ToList();
            return PartialView(values);
        }
        public PartialViewResult AchievementsScript()
        {
            var values = db.tbl_projects.ToList();
            return PartialView(values);
        }
        public PartialViewResult SubscribeScript()
        {
            return PartialView();
        }
    }
}