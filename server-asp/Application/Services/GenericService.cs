using Domain.Entities;
using Domain.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetEntitiesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task CreateEntityAsync(T entity)
        {
            // You can add additional business logic/validation here if needed
            await _repository.CreateAsync(entity);
        }

        public async Task<T> GetByIdEntityAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task DeleteEntityAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task UpdateEntityAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
