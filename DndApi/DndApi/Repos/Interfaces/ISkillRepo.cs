using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Entitys.Interfaces;
using DndApi.Repos.EmptyRepos;
using DndApi.Repos.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DndApi.Repos.Interfaces
{
    public interface ISkillRepo
    {
        Task<SkillEntity> Create(SkillEntity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<SkillEntity>> Get(SkillQuery query);
        Task<SkillEntity> Update(SkillEntity entity);
    }
}
