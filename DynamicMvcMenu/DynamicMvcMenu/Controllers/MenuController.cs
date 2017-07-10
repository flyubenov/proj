using System.Collections.Generic;
using System.Web.Mvc;
using DynamicMvcMenu.Models;

namespace DynamicMvcMenu.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public PartialViewResult Index()
        {
            List<Menu> menus = MenuGenerator.CreateMenu();
            return PartialView("Partials/_menu", menus);
        }
    }
}