using Graph.Web.Api.Interfaces;
using Graph.Web.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Graph.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProduct _productService;
        public ProductsController(IProduct productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product? Get(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Product? Post([FromBody] Product product)
        {
            return _productService.AddProduct(product);
        }

        [HttpPut("{id}")]
        public Product? Put(int id, [FromBody] Product product)
        {
            return _productService.UpdateProduct(id, product);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
            return;
        }
    }

}