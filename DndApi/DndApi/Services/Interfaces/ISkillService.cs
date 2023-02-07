using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Services.EmptyServices;
using DndApi.Services.Generic;

namespace DndApi.Services.Interfaces
{
    public interface ISkillService : IGenericService<SkillService, SkillRepo, SkillEntity, SkillRequest, SkillModel, SkillQuery>
    {
    }
}
