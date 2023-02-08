using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Controllers.Generic;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Services.EmptyServices;

namespace DndApi.Controllers
{
    public class WeaponController : GenericController<WeaponEntity, WeaponRequest, WeaponModel, WeaponQuery, WeaponService, WeaponRepo>
    {
        public WeaponController(WeaponService service) : base(service)
        {
        }
    }
}
