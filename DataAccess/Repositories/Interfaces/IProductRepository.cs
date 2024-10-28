using BusinessObject;
using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(ProductDTO productDTO);
        void UpdateProduct(int id, ProductDTO productDTO);
        void DeleteProduct(int productId);
    }
}
