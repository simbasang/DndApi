using Azure.Core;
using DndApi.Entitys.Interfaces;
using DndApi.Repos.Generic;
using DndApi.Services.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DndApi.Controllers.Generic
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GenericController<TEntity, TRequest, TModel, TQuery, TService, TRepo> : ControllerBase,
        IGenericController<TEntity, TRequest, TModel, TQuery, TService, TRepo>
        where TEntity : class, IEntity
        where TRequest : class
        where TModel : class
        where TQuery : class
        where TService : GenericService<TRepo, TEntity, TRequest, TModel, TQuery>
        where TRepo : GenericRepo<TEntity, TQuery>
    {
        private readonly TService _service;

        public GenericController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TModel>>> Get([FromQuery] TQuery query)
        {
            var result = await _service.Get(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<TModel>> Add([FromBody] TRequest request)
        {
            return await _service.Create(request);
        }

        [HttpPut]
        public async Task<ActionResult<TModel>> Update([FromQuery] Guid id, [FromBody] TRequest request)
        {
            return await _service.Update(id,request);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            return await _service.Delete(id);
        }
    }

}
