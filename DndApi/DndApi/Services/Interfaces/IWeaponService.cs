using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;

namespace DndApi.Services.Interfaces
{
    public interface IWeaponService
    {
        Task<WeaponModel> Create(WeaponRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<WeaponModel>> Get(WeaponQuery query);
        Task<WeaponModel> Update(Guid id, WeaponRequest request);
    }
}
