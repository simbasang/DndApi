using DndApi.Entitys.Interfaces;

namespace DndApi.Repos.Generic
{
    public interface IGenericRepo<T, Tentity, Tquery> where T : class
    {
        Task<Tentity> Create(Tentity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<Tentity>> Get(Tquery query);
        Task<Tentity> Update(Tentity entity);
    }
}