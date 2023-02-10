using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Controllers.Generic;
using DndApi.Entitys;
using DndApi.Repos;
using DndApi.Services.EmptyServices;
using DndApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{

    public class PlayerController : GenericController<PlayerEntity, PlayerRequest, PlayerModel, PlayerQuery, PlayerService, PlayerRepo>
    {
        public PlayerController(PlayerService service) : base(service)
        {
        }
    }
}
