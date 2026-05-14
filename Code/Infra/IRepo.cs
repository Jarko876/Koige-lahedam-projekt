using Abc.Data;
using Abc.Data.Common;

namespace Abc.Infra
{
    public interface IRepo<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetAsync(Guid id);
        Task<int> CountAsync();
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);

        Task DeleteAsync(Guid id);

    }

    public interface ISeatsRepo : IRepo<Seat>
    {
    }

    public interface IGenresRepo : IRepo<Genre>
    {
    }
}
