using WebApplication7.Models;
using WebApplication7.Repositories;

namespace WebApplication7.Services
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
    }
}
