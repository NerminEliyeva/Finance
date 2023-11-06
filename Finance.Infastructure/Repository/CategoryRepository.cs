using Finance.Domain;
using Finance.Domain.Entity;
using Finance.Domain.IRepository;

namespace Finance.Infastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FinanceDbContext _dbContext;
        public CategoryRepository(FinanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Category category)
        {
            await _dbContext.Categories.AddAsync(category);
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public Task<IEnumerable<Category>> GetAll(int userId, int type)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetById(int userId, int type, int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
