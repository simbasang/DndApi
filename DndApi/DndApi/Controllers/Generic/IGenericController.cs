using Azure.Core;
using DndApi.Entitys.Interfaces;
using DndApi.Repos.Generic;
using DndApi.Services.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers.Generic
{
    public interface IGenericController<TEntity, TRequest, TModel, TQuery, TService, TRepo>
        where TEntity : class, IEntity
        where TRequest : class
        where TModel : class
        where TQuery : class
        where TService : GenericService<TRepo, TEntity, TRequest, TModel, TQuery>
        where TRepo : GenericRepo<TEntity, TQuery>
    {
        Task<ActionResult<TModel>> Add([FromBody] TRequest request);
        Task<ActionResult<bool>> Delete([FromQuery] Guid id);
        Task<ActionResult<IEnumerable<TModel>>> Get([FromQuery] TQuery query);
        Task<ActionResult<TModel>> Update([FromBody] TRequest request);
    }
}
