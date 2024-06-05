using Domain;
using Service;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product GetById(int id)
        {
            return new Product() { Id = id , Price = 100, TaxRate = 20};
        }
    }
}
