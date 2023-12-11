using Microsoft.AspNetCore.Mvc;

namespace YUJCSR.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
