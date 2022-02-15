using Microsoft.AspNetCore.Mvc;

namespace FitnessIS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
