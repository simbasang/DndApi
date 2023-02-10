using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;

namespace DndApi.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<PlayerModel> Create(PlayerRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<PlayerModel>> Get(PlayerQuery query);
        Task<PlayerModel> Update(Guid id, PlayerRequest request);
    }
}