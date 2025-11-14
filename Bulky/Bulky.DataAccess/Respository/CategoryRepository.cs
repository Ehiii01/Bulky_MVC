

using Bulky.DataAccess.Data;
using Bulky.Models;

namespace Bulky.DataAccess.Respository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
      

      
        public void Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
