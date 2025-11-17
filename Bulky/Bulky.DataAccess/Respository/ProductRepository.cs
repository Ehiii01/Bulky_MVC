

using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respository.IRepository;
using Bulky.Models;

namespace Bulky.DataAccess.Respository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }



        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
