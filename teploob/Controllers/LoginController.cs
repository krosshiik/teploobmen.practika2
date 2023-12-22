using Microsoft.AspNetCore.Mvc;

namespace teploob.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Index(string login, string password)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string login, string password)
        {
            return View();
        }
    }
}
