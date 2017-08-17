using Microsoft.AspNetCore.Mvc;

namespace ExternalLogins.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A broad overview of the application in general.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "My Contacts";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
