using Microsoft.AspNetCore.Mvc;

namespace YUJCSR.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
