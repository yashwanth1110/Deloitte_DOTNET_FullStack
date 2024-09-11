using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public IProductService _service;
        public ProductApiController(IProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAllProdutcs()
        {
            return Ok(_service.GetAllProducts());
        }


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _service.GetProductById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested Product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpPost]
        public IActionResult CreateProduct(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "Product Details added to db" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Product obj = _service.GetProductById(id);
            if (obj == null)
            {
                return NotFound(new { result = "Requested Product details are not available." });
            }
            else
            {
                _service.DeleteProduct(id);
                return Ok(new { result = "Product Details deleted sucessfully" });
            }

        }

        [HttpPut]
        public IActionResult UpdateProduct(Product obj)
        {


            if (obj == null)
            {
                return NotFound(new { result = "Requested product details are not available." });
            }
            else
            {
                _service.UpdateProduct(obj);
                return Ok(new { result = "Product Details updated sucessfully" });
            }

        }
    }
}
