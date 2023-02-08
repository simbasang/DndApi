using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;

namespace DndApi.Services.Interfaces
{
    public interface IArmorService
    {
        Task<ArmorModel> Create(ArmorRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<ArmorModel>> Get(ArmorQuery query);
        Task<ArmorModel> Update(ArmorRequest request);
    }
}
