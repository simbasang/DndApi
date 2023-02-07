using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Services.Interfaces;

namespace DndApi.Services
{
    public class PlayerService : IPlayerService
    {
        public async Task<PlayerModel> GetPlayers(PlayerQuery query)
        {
            return null;
        }
        public async Task<PlayerModel> CreatePlayer(PlayerRequest request)
        {
            return null;
        }
        public async Task<PlayerModel> UpdatePlayer(PlayerRequest request)
        {
            return null;
        }
        public async Task<PlayerModel> DeletePlayer(Guid id)
        {
            return null;
        }
    }
}
