using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Services.Interfaces
{
    public interface IArmorService
    {
        Task<ArmorModel> Create(ArmorRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<ArmorModel>> Get(ArmorQuery query);
        Task<ArmorModel> Update(Guid id,ArmorRequest request);
    }
}
