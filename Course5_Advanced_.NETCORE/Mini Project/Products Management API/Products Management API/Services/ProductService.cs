using Products_Management_API.Models;
using Products_Management_API.Repositories;

namespace Products_Management_API.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }
        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void AddProduct(Product productObj)
        {
            _repository.AddProduct(productObj);
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }
        public void UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
        }
        public List<Product> GetProductsByCategory(string category)
        {
            return _repository.GetProductsByCategory(category);
        }
        public List<Product> GetOutOfStockProducts()
        {
            return _repository.GetOutOfStockProducts();
        }
        public List<Product> GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            return _repository.GetProductsByPriceRange(minPrice, maxPrice);
        }
        public List<string> GetAllCategories()
        {
            return _repository.GetAllCategories();
        }
    }
}