using AutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoComplete.Controllers
{
    public class SupController : Controller
    {
        private MyEntities db = new MyEntities();
        // GET: Sup
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetData (string Prefix)
        {
            var Countries = (from c in db.Suppliers
                             where c.Name.Contains(Prefix)
                             select new { c.Name, c.Id });
            return Json(Countries, JsonRequestBehavior.AllowGet);
        }
    }
}