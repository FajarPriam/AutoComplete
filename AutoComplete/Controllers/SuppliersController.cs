using AutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoComplete.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: Suppliers
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            //Note : you can bind same list from database  
            List<Supplier> ObjList = new List<Supplier>()
            {

                new Supplier {Id=1,Name="Pama" },
                new Supplier {Id=2,Name="Indofood" },
                new Supplier {Id=3,Name="Astra" },
                new Supplier {Id=4,Name="Yamaha" },
                new Supplier {Id=5,Name="Metrodata" },
                new Supplier {Id=6,Name="Nokia" },
                new Supplier {Id=7,Name="IndoGroub" }

        };
            //Searching records from list using LINQ query  
            var CityList = (from N in ObjList
                            where N.Name.Contains(Prefix)
                            select new { N.Name });
            return Json(CityList, JsonRequestBehavior.AllowGet);
        }
    }
}