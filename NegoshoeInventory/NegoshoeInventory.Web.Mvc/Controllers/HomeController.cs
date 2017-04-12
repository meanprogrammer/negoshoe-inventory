using NegoShoePH.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NegoshoeInventory.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        ItemData data;
        public HomeController() {
            data = new ItemData();
        }

        public ActionResult Index()
        {
            List<Item> items = data.GetAllItem(0,0);
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}