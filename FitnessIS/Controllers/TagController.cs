using FitnessIS.Data;
using FitnessIS.Models;
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
            IEnumerable<Tag> tags = _dbContext.tags.ToList();
            return View(tags);
        }
    }
}
