using AutoMapper;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos;
using DndApi.Services.Generic;
using DndApi.Services.Interfaces;

namespace DndApi.Services.EmptyServices
{
    public class PlayerService : GenericService<PlayerRepo, PlayerEntity, PlayerRequest, PlayerModel, PlayerQuery>, IPlayerService
    {
        public PlayerService(PlayerRepo repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
