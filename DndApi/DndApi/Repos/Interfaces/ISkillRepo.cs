using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Repos.Generic;

namespace DndApi.Repos.Interfaces
{
    public interface ISkillRepo: IGenericRepo<SkillRepo, SkillEntity, SkillQuery>
    {
    }
}
