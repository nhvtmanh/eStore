using BusinessObject;
using DataAccess.DTOs;
using DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPI : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductAPI(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDTO productDTO)
        {
            if (ModelState.IsValid)
            {
                _productRepository.AddProduct(productDTO);
                return Ok(productDTO);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductDTO productDTO)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productRepository.UpdateProduct(id, productDTO);
            return NoContent();
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return NoContent();
        }
    }
}
