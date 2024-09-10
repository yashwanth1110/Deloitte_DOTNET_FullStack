using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee_Management_Portal___Admin.Models;
namespace Employee_Management_Portal___Admin.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _db;

        public EmployeeController(EmployeeDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Employee> employees = _db.Employees.ToList();
            return View(employees);
        }
        public IActionResult DepartmentDetails()
        {
            List<Employee> employees = _db.Employees.ToList();
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(emp);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult DetailInfo(string department)
        {
            List<Employee> employees;


            if (!string.IsNullOrEmpty(department))
            {
                employees = _db.Employees.Where(e => e.Department == department).ToList();
            }
            else
            {
                employees = _db.Employees.ToList();
            }
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            Employee obj = _db.Employees.Find(id);
            return View(obj);
        }
        public IActionResult Edit(int id)
        {
            Employee obj = _db.Employees.Find(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            _db.Employees.Update(emp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Employee obj = _db.Employees.Find(id);
            return View(obj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteInfo(int id)
        {
            Employee emp = _db.Employees.Find(id);
            _db.Employees.Remove(emp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
