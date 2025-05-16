using Microsoft.AspNetCore.Mvc;
using RecipeShare.Data;
using RecipeShare.Models;
using System.Diagnostics;
using System.Linq;

namespace RecipeShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Get the 3 most recent recipes for the homepage
            var recentRecipes = _context.Recipes
                .OrderByDescending(r => r.DateCreated)
                .Take(3)
                .ToList();

            return View(recentRecipes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}