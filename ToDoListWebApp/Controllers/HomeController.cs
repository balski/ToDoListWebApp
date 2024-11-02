using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoListWebApp.Data;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        [Route("/signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult SignUp(Users user)
        {
            using (var db = new ToDoListDBContext())
            {
                db.Add(user);
                db.SaveChanges();
            }

            return View();
        }
    }
}
