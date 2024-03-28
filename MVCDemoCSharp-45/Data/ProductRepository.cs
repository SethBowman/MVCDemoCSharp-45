using Dapper;
using MVCDemoCSharp_45.Models;
using System.Data;

namespace MVCDemoCSharp_45.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
}
