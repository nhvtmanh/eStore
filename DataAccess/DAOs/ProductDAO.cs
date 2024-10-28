using BusinessObject;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class ProductDAO
    {
        private readonly EStoreDbContext _dbContext;

        public ProductDAO(EStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _dbContext.Products.Find(productId);
        }

        public void AddProduct(ProductDTO productDTO)
        {
            var product = new Product
            {
                CategoryId = productDTO.CategoryId,
                ProductName = productDTO.ProductName,
                Weight = productDTO.Weight,
                UnitPrice = productDTO.UnitPrice,
                UnitsInStock = productDTO.UnitsInStock
            };

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(int id, ProductDTO productDTO)
        {
            var product = _dbContext.Products.Find(id);

            product.CategoryId = productDTO.CategoryId;
            product.ProductName = productDTO.ProductName;
            product.Weight = productDTO.Weight;
            product.UnitPrice = productDTO.UnitPrice;
            product.UnitsInStock = productDTO.UnitsInStock;

            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }
    }
}
