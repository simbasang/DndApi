using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;

namespace DndApi.Repos.Interfaces
{
    public interface IPlayerRepo
    {
        Task<PlayerModel> CreatePlayer(PlayerEntity request);
        Task<PlayerModel> DeletePlayer(Guid id);
        Task<PlayerModel> GetPlayers(PlayerQuery query);
        Task<PlayerModel> UpdatePlayer(PlayerEntity request);
    }
}