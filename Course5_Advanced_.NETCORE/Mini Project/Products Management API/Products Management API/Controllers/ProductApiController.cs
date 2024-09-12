using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products_Management_API.Models;
using Products_Management_API.Services;

namespace Products_Management_API.Controllers
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
        [HttpGet("category/{category}")]
        public IActionResult GetProductsByCategory(string category)
        {
            var products = _service.GetProductsByCategory(category);
            return Ok(products);
        }
        [HttpGet("outofstock")]
        public IActionResult GetOutOfStockProducts()
        {
            var products = _service.GetOutOfStockProducts();
            return Ok(products);
        }
        [HttpGet("pricerange")]
        public IActionResult GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            var products = _service.GetProductsByPriceRange(minPrice, maxPrice);
            return Ok(products);
        }
        [HttpGet("category")]
        public IActionResult GetAllCategories()
        {
            var products = _service.GetAllCategories();
            return Ok(products);
        }
    }
}
