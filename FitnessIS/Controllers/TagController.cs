using FitnessIS.Data;
using Microsoft.AspNetCore.Mvc;

namespace FitnessIS.Controllers
{
    public class TagController : Controller
    {
        private readonly DatabaseContext _dbContext;
        public TagController(DatabaseContext dbContext)
        {
            _dbContext= dbContext;
        }
        public IActionResult Index()
        {
            var tags = _dbContext.tags.ToList();
            return View();
        }
    }
}
