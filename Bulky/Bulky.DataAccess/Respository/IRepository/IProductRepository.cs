using Bulky.Models;

namespace Bulky.DataAccess.Respository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        
        void Update(Product obj);
    }
}
