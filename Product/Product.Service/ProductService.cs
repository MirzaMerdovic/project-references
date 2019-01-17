using Common.Services;
using Product.Repository;

namespace Product.Service
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IConfigurationService _configurationService;

        public ProductService(IProductRepository productRepository, IConfigurationService configurationService)
        {
            _productRepository = productRepository;
            _configurationService = configurationService;
        }
    }
}