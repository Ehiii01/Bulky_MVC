using Bulky.Models;

namespace Bulky.DataAccess.Respository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        
        void Update(Category obj);  
    }
}
