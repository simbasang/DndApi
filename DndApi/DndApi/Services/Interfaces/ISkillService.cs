using Azure.Core;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Services.EmptyServices;
using DndApi.Services.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DndApi.Services.Interfaces
{
    public interface ISkillService 
    {
        Task<SkillModel> Create(SkillRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<SkillModel>> Get(SkillQuery query);
        Task<SkillModel> Update(SkillRequest request);
    }
}
