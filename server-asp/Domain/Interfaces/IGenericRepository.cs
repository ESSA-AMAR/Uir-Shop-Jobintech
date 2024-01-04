namespace Domain.Interfaces

{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(int id);
    }
}
