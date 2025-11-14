

using Bulky.DataAccess.Respository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Respository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        
        void Update(Category obj);  
    }
}
