using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos.Interfaces;

namespace DndApi.Repos
{
    public class PlayerRepo : IPlayerRepo
    {
        public async Task<PlayerModel> GetPlayers(PlayerQuery query)
        {
            return null;
        }
        public async Task<PlayerModel> CreatePlayer(PlayerEntity request)
        {
            return null;
        }
        public async Task<PlayerModel> UpdatePlayer(PlayerEntity request)
        {
            return null;
        }
        public async Task<PlayerModel> DeletePlayer(Guid id)
        {
            return null;
        }
    }
}
