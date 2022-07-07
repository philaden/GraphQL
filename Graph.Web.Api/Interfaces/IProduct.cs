using Graph.Web.Api.Models;

namespace Graph.Web.Api.Interfaces
{
    public interface IProduct
    {
        List<Product>GetAllProducts();
        Product AddProduct(Product product);
        Product UpdateProduct(int Id, Product product);
        void DeleteProduct(int id);
        Product? GetProductById(int id);
    }
}