using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;

namespace DndApi.Services.Interfaces
{
    public interface ISkillService 
    {
        Task<SkillModel> Create(SkillRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<SkillModel>> Get(SkillQuery query);
        Task<SkillModel> Update(Guid id,SkillRequest request);
    }
}
