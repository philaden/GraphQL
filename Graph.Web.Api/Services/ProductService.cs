using Graph.Web.Api.Interfaces;
using Graph.Web.Api.Models;

namespace Graph.Web.Api.Services
{
    public class ProductService : IProduct
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(){ Id = 1, Name = "Coffee", Price = 10},
            new Product(){ Id = 2, Name = "Tea", Price = 20},
            new Product(){ Id = 3, Name = "Bread", Price = 30},
        };
        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product? GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
        }
    }
}