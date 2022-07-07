using Graph.Web.Api.Models;
using GraphQL.Types;

namespace Graph.Web.Api.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }   
    }
}