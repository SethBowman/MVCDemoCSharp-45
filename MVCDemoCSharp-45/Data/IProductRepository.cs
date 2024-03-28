using MVCDemoCSharp_45.Models;

namespace MVCDemoCSharp_45.Data
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
