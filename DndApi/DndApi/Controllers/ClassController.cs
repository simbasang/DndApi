using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Controllers.Generic;
using DndApi.Entitys;
using DndApi.Repos;
using DndApi.Services.EmptyServices;

namespace DndApi.Controllers
{
    public class ClassController : GenericController<ClassEntity, ClassRequest, ClassModel, ClassQuery, ClassService, ClassRepo>
    {
        public ClassController(ClassService service) : base(service)
        {
        }
    }
}
