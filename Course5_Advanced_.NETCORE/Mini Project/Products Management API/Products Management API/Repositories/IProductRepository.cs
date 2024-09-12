using Products_Management_API.Models;

namespace Products_Management_API.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product productObj);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsByPriceRange(int minPrice, int maxPrice);
        List<string> GetAllCategories();
       
    }
}
