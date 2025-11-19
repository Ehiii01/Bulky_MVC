

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

            //var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            //if(objFromDb != null)
            //{
            //    objFromDb.Title = obj.Title;
            //    objFromDb.ISBN = obj.ISBN;
            //    objFromDb.Price = obj.Price;
            //    objFromDb.Price50 = obj.Price50 ;
            //    objFromDb.ListPrice = obj.ListPrice;
            //    objFromDb.Description = obj.Description;
            //    objFromDb.CategoryId = obj.CategoryId;
            //    objFromDb.Author = obj.Author;
            //    if (obj.ImageUrl != null)
            //    {
            //        obj.ImageUrl = obj.ImageUrl;
            //    }
            //}
        }
    }
}
