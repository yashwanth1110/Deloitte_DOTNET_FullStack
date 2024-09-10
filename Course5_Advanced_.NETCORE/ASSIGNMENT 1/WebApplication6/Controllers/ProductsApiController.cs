using Microsoft.AspNetCore.Http;
using WebApplication6.Models;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        public SalesDbContext _context;

        public ProductsApiController(SalesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _context.Products.Find(id);

            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(new { status = "Requested Product details does not exists." });
            }
        }

        [HttpPost]
        public IActionResult CreateStudent(Product obj)
        {
            _context.Products.Add(obj);
            _context.SaveChanges();
            return Ok(new { status = "New Product details added in server." });
        }

        [HttpPut]
        public IActionResult EditStudent(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
            return Ok(new { status = "Student details updated in server." });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            Product obj = _context.Products.Find(id);

            if (obj != null)
            {
                _context.Products.Remove(obj);
                _context.SaveChanges();
                return Ok(new { status = "Student details are deleted from server." });
            }
            else
            {
                return NotFound(new { status = "Requested student details does not exists." });
            }
        }

    }
}
