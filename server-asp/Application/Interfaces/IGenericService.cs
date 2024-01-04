using Domain.Entities;

namespace Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetEntitiesAsync();
        Task<T> GetByIdEntityAsync(int id);
        Task CreateEntityAsync(T entity);
        Task UpdateEntityAsync(T entity);
        Task DeleteEntityAsync(int id);
    }
}
