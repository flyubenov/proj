using System.Web.Mvc;
using DynamicMvcMenu.Areas.Configuration.Controllers;

namespace DynamicMvcMenu.Controllers
{
    [MenuItem(ParentController = typeof(SettingsController))]
    public class ProductController : Controller
    {
        // GET: Product
        [MenuItem]
        public ActionResult Index()
        {
            return View();
        }
    }
}