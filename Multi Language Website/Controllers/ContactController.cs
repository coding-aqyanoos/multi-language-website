using Microsoft.AspNetCore.Mvc;

namespace Multi_Language_Website.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
