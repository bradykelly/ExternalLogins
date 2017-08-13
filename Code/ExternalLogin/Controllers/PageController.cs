using Microsoft.AspNetCore.Mvc;

namespace ExternalLogins.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Home");
        }

        public ActionResult ThePage()
        {
            return View();
        }
    }
}