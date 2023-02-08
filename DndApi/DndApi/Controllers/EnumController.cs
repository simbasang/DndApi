using DndApi.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{
    [Route("Api/v1/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetValues(string type)
        {

            var chosenEnum = Type.GetType($"DndApi.Enums.{type}");

            if (chosenEnum == null)
                return BadRequest($"Ther is no Enum whit the name {type}");

            return Ok(Enum.GetNames(chosenEnum));
        }
    }
}
