using Microsoft.AspNetCore.Mvc;

namespace TakiUI4.Areas.Admin.Controllers
{
    public class AdminMain : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
