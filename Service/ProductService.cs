using Microsoft.Extensions.Logging;

namespace Service
{
    public class ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
    {
        public decimal CalculateKdv(int productId)
        {
            logger.LogInformation("method çalıştı");
            var product = productRepository.GetById(productId);
            var taxWithCalculated = product.Price * product.TaxRate;

            return taxWithCalculated;
        }

    }
}
