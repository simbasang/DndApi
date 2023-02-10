using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Controllers.Generic;
using DndApi.Entitys;
using DndApi.Repos;
using DndApi.Services.EmptyServices;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{
    public class ArmorController : GenericController<ArmorEntity, ArmorRequest, ArmorModel, ArmorQuery, ArmorService, ArmorRepo>
    {
        public ArmorController(ArmorService service) : base(service)
        {
        }
    }
}
