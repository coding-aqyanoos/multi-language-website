using Microsoft.AspNetCore.Mvc;

namespace Multi_Language_Website.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
