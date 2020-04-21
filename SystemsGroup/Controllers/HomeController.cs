using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemGroup.Data.Services;

namespace SystemsGroup.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;
        public HomeController()
        {
            db = new InMemoryRestaurantData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View();
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