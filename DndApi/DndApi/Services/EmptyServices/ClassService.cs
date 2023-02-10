using AutoMapper;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos;
using DndApi.Services.Generic;
using DndApi.Services.Interfaces;

namespace DndApi.Services.EmptyServices
{
    public class ClassService : GenericService<ClassRepo, ClassEntity, ClassRequest, ClassModel, ClassQuery>, IClassService
    {
        public ClassService(ClassRepo repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
