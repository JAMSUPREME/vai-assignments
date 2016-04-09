using System.Web.Mvc;
using System.Linq;

namespace EasyBootstrapMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.PageName = "Index";
            return View();
        }

        // GET: Home/MVC
        public ActionResult MVC()
        {
            ViewBag.PageName = "MVC";
            ViewData["DropDownData"] = new string[] { "cat", "hat" }.Select(x => new SelectListItem { Text = x, Value = x });
            return View();
        }

        // GET: Home/JQuery
        public ActionResult JQuery()
        {
            ViewBag.PageName = "JQuery";
            return View();
        }

        // GET: Home/Bootstrap
        [Route]
        public ActionResult Bootstrap()
        {
            ViewBag.PageName = "Bootstrap";
            return View();
        }

        //
        // TODO: Code for a new route (e.g. "Cats") should go here
        //
        public ActionResult Cats()
        {
            ViewBag.PageName = "Cats";
            return View();
        }
    }
}