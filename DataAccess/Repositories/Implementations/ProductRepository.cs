using BusinessObject;
using DataAccess.DAOs;
using DataAccess.DTOs;
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

        public void AddProduct(ProductDTO productDTO) => _productDAO.AddProduct(productDTO);

        public void UpdateProduct(int id, ProductDTO productDTO) => _productDAO.UpdateProduct(id, productDTO);

        public void DeleteProduct(int productId) => _productDAO.DeleteProduct(productId);
    }
}
