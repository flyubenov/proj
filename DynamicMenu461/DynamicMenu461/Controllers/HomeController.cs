using DynamicMenu461.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMenu461.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public PartialViewResult GetDynamicViewItems()
        {
            var model = new DynamicMenuViewModel();
            model.MenuItems = GetMenu();

            
            return PartialView("DynamicSidebarView", model);
        }

        private IEnumerable<MenuItem> GetMenu()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { LinkText = "Home", ActionName = "Index", ControllerName = "Home" });
            menuItems.Add(new MenuItem() { LinkText = "About", ActionName = "About", ControllerName = "Home" });
            menuItems.Add(new MenuItem() { LinkText = "Contact", ActionName = "Contact", ControllerName = "Home" });

            return menuItems;
        }


    }
}