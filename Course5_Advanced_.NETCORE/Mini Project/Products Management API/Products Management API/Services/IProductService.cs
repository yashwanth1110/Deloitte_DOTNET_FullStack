using Products_Management_API.Models;
using Products_Management_API.Repositories;

namespace Products_Management_API.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product productObj);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsByPriceRange(int minPrice, int maxPrice);
        List<String> GetAllCategories();

    }
}
