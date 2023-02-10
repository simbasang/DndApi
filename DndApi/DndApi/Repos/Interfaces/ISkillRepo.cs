using DndApi.Contracts.Querys;
using DndApi.Entitys;

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
