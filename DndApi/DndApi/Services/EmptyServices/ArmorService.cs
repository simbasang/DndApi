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
    public class ArmorService : GenericService<ArmorRepo, ArmorEntity, ArmorRequest, ArmorModel, ArmorQuery>, IArmorService
    {
        public ArmorService(ArmorRepo repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
