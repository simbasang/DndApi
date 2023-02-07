using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Controllers.Generic;
using DndApi.Entitys;
using DndApi.Repos.EmptyRepos;
using DndApi.Services.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : GenericController<SkillController, SkillRepo, SkillEntity, SkillRequest, SkillModel, SkillQuery>
    {
        public SkillController(IGenericService<SkillController, SkillRepo, SkillEntity, SkillRequest, SkillModel, SkillQuery> service) : base(service)
        {
        }
    }
}
