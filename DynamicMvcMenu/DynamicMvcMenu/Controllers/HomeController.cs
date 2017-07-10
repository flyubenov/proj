using System.Web.Mvc;

namespace DynamicMvcMenu.Controllers
{

    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [MenuItem(Title = "Home", Order = 500, CssIcon = "fa fa-home fa-lg fa-fw")]
        public ActionResult Index()
        {
            return View();
        }
        [MenuItem()]
        public ActionResult FeaturedExample()
        {
            return View();
        }
        [MenuItem()]
        public ActionResult DialogExample()
        {
            return View();
        }
    }
}
