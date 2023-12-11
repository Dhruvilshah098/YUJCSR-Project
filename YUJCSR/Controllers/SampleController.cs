using Microsoft.AspNetCore.Mvc;

namespace YUJCSR.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Messages()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}
