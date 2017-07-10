using System.Web.Mvc;

namespace DynamicMvcMenu.Areas.Configuration.Controllers
{
    [MenuItem(IsClickable = false)]
    [AuthorizedRole("Admin")]
    public class SettingsController : Controller
    {
        // GET: Configuration/Settings
        [MenuItem]
        public ActionResult Index()
        {
            return View();
        }
    }
}