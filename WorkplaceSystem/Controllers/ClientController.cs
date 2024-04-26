using Microsoft.AspNetCore.Mvc;

namespace WorkplaceSystem.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
