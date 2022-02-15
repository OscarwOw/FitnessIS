using FitnessIS.Data;
using Microsoft.AspNetCore.Mvc;

namespace FitnessIS.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly DatabaseContext _dbContext;
        public AccountController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
  
        public IActionResult login()
        {
            return View();
        }
    }
}
