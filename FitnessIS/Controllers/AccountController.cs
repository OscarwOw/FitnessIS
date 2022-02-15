using FitnessIS.Data;
using Microsoft.AspNetCore.Mvc;

namespace FitnessIS.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext _dbContext;
        public AccountController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
  
        public IActionResult Index()
        {
            return View();
        }
    }
}
