using DndApi.Contracts.Querys;
using DndApi.Entitys;

namespace DndApi.Repos.Interfaces
{
    public interface IWeaponRepo
    {
        Task<WeaponEntity> Create(WeaponEntity entity);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<WeaponEntity>> Get(WeaponQuery query);
        Task<WeaponEntity> Update(WeaponEntity entity);
    }
}
