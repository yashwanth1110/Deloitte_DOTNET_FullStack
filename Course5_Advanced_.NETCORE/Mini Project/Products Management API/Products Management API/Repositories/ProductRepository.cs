using Products_Management_API.Models;
using Products_Management_API.Repositories;

namespace Products_Management_API.Repositories
{
    public class ProductRepository : IProductRepository
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

        public List<Product> GetProductsByCategory(string category)
        {
            return _context.Products.Where(p => p.Category == category).ToList();
        }
        public List<Product> GetOutOfStockProducts()
        {
            return _context.Products.Where(p => p.Quantity == 0).ToList();
        }

        public List<Product> GetProductsByPriceRange(int minPrice, int maxPrice)
        {
            return _context.Products.Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList();
        }

        public List<string> GetAllCategories()
        {
            return _context.Products.Select(p => p.Category).Distinct().ToList();
        }

    }
}