using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlayerController : ControllerBase
    {
        public readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
                
        [HttpGet]
        public async Task<ActionResult> GetPlayers([FromQuery] PlayerQuery query)
        {
            return Ok(await _playerService.GetPlayers(query));
        }
        [HttpPost]
        public async Task<ActionResult> CreatePlayer([FromQuery] PlayerRequest request)
        {
            return Ok(await _playerService.CreatePlayer(request));
        }
        [HttpPut]
        public async Task<ActionResult> UpdatePlayer([FromQuery] PlayerRequest request)
        {
            return Ok(await _playerService.UpdatePlayer(request));
        }
        [HttpDelete]
        public async Task<ActionResult> DeletePlayer(Guid id)
        {
            return Ok(await _playerService.DeletePlayer(id));
        }
    }
}
