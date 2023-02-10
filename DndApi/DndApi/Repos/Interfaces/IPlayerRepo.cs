using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;

namespace DndApi.Repos.Interfaces
{
    public interface IPlayerRepo
    {
        Task<PlayerEntity> Create(PlayerEntity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<PlayerEntity>> Get(PlayerQuery query);
        Task<PlayerEntity> Update(PlayerEntity entity);
    }
}