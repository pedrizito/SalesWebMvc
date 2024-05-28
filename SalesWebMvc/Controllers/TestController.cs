using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
