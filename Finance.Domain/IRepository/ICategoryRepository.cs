using Finance.Domain.Entity;

namespace Finance.Domain.IRepository
{
    public interface ICategoryRepository
    {
        Task Create(Category category);
        Task Save();
        Task<IEnumerable<Category>> GetAll(int userId, int type);
        Task<IEnumerable<Category>> GetById(int userId, int type, int categoryId);
    }
}
