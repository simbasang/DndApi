using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;

namespace DndApi.Services.Interfaces
{
    public interface IClassService
    {
        Task<ClassModel> Create(ClassRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<ClassModel>> Get(ClassQuery query);
        Task<ClassModel> Update(Guid id, ClassRequest request);
    }
}
