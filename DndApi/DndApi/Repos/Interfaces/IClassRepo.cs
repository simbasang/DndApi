using DndApi.Contracts.Querys;
using DndApi.Entitys;

namespace DndApi.Repos.Interfaces
{
    public interface IClassRepo
    {
        Task<ClassEntity> Create(ClassEntity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<ClassEntity>> Get(ClassQuery query);
        Task<ClassEntity> Update(ClassEntity entity);
    }
}
