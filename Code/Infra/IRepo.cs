using Abc.Data;
using Abc.Data.Common;

namespace Abc.Infra {
    public interface IRepo<TEntity> where TEntity : BaseEntity {
        Task<TEntity> GetAsync(Guid id);
        Task<int> CountAsync(Query q);
        Task<IEnumerable<TEntity>> GetAsync(Query q);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
    }
    public interface ISeatsRepo: IRepo<Seat>{  }
    public interface IEventsRepo: IRepo<Event> { }
    public interface IHallsRepo : IRepo<Hall> { }
    public interface IHallCategoriesRepo : IRepo<HallCategory> { }
    public interface IPersonsRepo : IRepo<Person> { }
    public interface IRolesRepo : IRepo<Role> { }
    public interface IUserRolesRepo : IRepo<UserRole> { }

}
