using ApotheekApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DataContext _dataContext;

        public EFRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dataContext.AddAsync(entity);
            return entity;
        }

        public async Task Delete(int id)
        {
            _dataContext.Remove(await GetByIdAsync(id));
            await _dataContext.SaveChangesAsync();//ToDO: Is this needed?
        }

        public IQueryable<T> GetAll()
        {
            return _dataContext.Set<T>() ?? throw new ArgumentException("No data exists");
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dataContext.Set<T>().Where(e => e.Id == id).SingleOrDefaultAsync() ?? throw new ArgumentException("Id not found");
        }

        public async Task SaveChangesAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dataContext.Update(entity);
            await _dataContext.SaveChangesAsync();//ToDO: Is this needed?
            return entity;
        }
    }
}