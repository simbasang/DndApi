using DndApi.Entitys.Interfaces;

namespace DndApi.Repos.Generic
{
    public interface IGenericRepo<TEntity, TQuery> where TEntity : IEntity
    {
        Task<TEntity> Create(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<TEntity>> Get(TQuery query);
        Task<TEntity> Update(TEntity entity);
    }
}