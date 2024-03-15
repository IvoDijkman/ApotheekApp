namespace ApotheekApp.Domain.Interfaces
{
    public interface IEFRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task Delete(int id);

        Task SaveChangesAsync();
    }
}