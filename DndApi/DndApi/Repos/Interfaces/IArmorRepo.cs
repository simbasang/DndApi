using DndApi.Contracts.Querys;
using DndApi.Entitys;

namespace DndApi.Repos.Interfaces
{
    public interface IArmorRepo
    {
        Task<ArmorEntity> Create(ArmorEntity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<ArmorEntity>> Get(ArmorQuery query);
        Task<ArmorEntity> Update(ArmorEntity entity);

    }
}
