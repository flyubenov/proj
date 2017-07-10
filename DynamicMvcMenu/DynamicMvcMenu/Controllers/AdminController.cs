using System.Web.Mvc;

namespace DynamicMvcMenu.Controllers
{
    [MenuItem (Action = "Users")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [MenuItem(CssIcon = "fa fa-users fa-lg fa-fw")]
        [AuthorizedRole("Admin")]
        public ActionResult Users()
        {
            return View();
        }
        [MenuItem(Title = "Site Settings")]
        [AuthorizedRole("Super user")]
        public ActionResult Settings()
        {
            return View();
        }
    }
}