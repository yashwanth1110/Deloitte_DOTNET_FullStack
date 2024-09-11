using WebApplication7.Models;

namespace WebApplication7.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product productObj);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
