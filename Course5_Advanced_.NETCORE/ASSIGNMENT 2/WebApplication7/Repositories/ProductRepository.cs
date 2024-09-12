using WebApplication7.Models;
using WebApplication7.Repositories;

namespace WebApplication7.Repositories
{
    public class ProductRepository:IProductRepository
    {
        public SalesDbContext _context;
        public ProductRepository(SalesDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }
        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product productObj)
        {
            _context.Products.Add(productObj);
            _context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Product product = _context.Products.Find(id);

            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
