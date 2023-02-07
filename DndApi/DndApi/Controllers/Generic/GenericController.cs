using Azure.Core;
using DndApi.Entitys.Interfaces;
using DndApi.Services.Generic;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DndApi.Controllers.Generic
{
    [ApiController]
    public class GenericController<T, Trepo, Tentity, Trequest, Tmodel, Tquery> : ControllerBase where T : class
    {
        private readonly IGenericService<T, Trepo, Tentity, Trequest, Tmodel, Tquery> _service;

        public GenericController(IGenericService<T, Trepo, Tentity, Trequest, Tmodel, Tquery> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tmodel>>> Get([FromQuery] Tquery query)
        {
            var result = await _service.Get(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Tmodel>> Add([FromBody] Trequest request)
        {
            return await _service.Create(request);
        }

        [HttpPut]
        public async Task<ActionResult<Tmodel>> Update([FromBody] Trequest request)
        {
            return await _service.Update(request);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            return await _service.Delete(id);
        }
    }

}
