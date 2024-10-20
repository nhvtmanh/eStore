using BusinessObject;
using DataAccess.DAOs;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDAO;

        public ProductRepository(EStoreDbContext context)
        {
            _productDAO = new ProductDAO(context);
        }

        public IEnumerable<Product> GetAllProducts() => _productDAO.GetAllProducts();

        public Product GetProductById(int productId) => _productDAO.GetProductById(productId);

        public void AddProduct(Product product) => _productDAO.AddProduct(product);

        public void UpdateProduct(Product product) => _productDAO.UpdateProduct(product);

        public void DeleteProduct(int productId) => _productDAO.DeleteProduct(productId);
    }
}
