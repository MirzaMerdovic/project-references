using System.Threading.Tasks;
using Common;

namespace Product.Repository
{
    public interface IProductRepository
    {
        Task<Product> Get(int id);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly ICache _cache;

        public ProductRepository(ICache cache)
        {
            _cache = cache;
        }
        public Task<Product> Get(int id)
        {
            return Task.FromResult(new Product { Id = id, Name = "Faker" });
        }
    }
}