using AutoMapper;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Repos.Generic;
using DndApi.Services.Generic;
using DndApi.Services.Interfaces;

namespace DndApi.Services.EmptyServices
{
    public class SkillService : GenericService<SkillRepo,SkillEntity,SkillRequest,SkillModel,SkillQuery>, ISkillService 
    {
        public SkillService(SkillRepo repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
