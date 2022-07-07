using Graph.Web.Api.Query;

namespace Graph.Web.Api.Schema
{
    public class ProductSchema : GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery)
        {
            Query = productQuery;
        }        
    }
}