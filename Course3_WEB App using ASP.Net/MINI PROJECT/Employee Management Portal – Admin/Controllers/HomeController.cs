using Employee_Management_Portal___Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employee_Management_Portal___Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext _db1;

        public HomeController(EmployeeDbContext db)
        {
            _db1 = db;
        }

        public IActionResult SignUp()
        {
            return View();

        }
        [HttpPost]
        public IActionResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                _db1.Users.Add(user);
                _db1.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        // For GET Request
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // For POST Request
        [HttpPost]
        public IActionResult Login(string uid, string pwd)
        {

            if (uid == "admin" && pwd == "admin123")
            {
                ViewData["result"] = "Welcome to Admin";
                return RedirectToAction("Index","Employee");
            }
            else
            {
                ViewData["result"] = "Invalid User Id or Password";
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
