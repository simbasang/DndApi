using AutoMapper;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Services.Generic;
using DndApi.Services.Interfaces;

namespace DndApi.Services.EmptyServices
{
    public class WeaponService : GenericService<WeaponRepo, WeaponEntity, WeaponRequest, WeaponModel, WeaponQuery>, IWeaponService
    {
        public WeaponService(WeaponRepo repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
