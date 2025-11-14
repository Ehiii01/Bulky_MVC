

using Bulky.Models;

namespace Bulky.DataAccess.Respository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}
