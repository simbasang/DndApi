using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;

namespace DndApi.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<PlayerModel> CreatePlayer(PlayerRequest request);
        Task<PlayerModel> DeletePlayer(Guid id);
        Task<PlayerModel> GetPlayers(PlayerQuery query);
        Task<PlayerModel> UpdatePlayer(PlayerRequest request);
    }
}