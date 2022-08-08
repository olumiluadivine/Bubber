using Bubber.Contracts.BreakFast;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bubber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastController : ControllerBase
    {
        [HttpPost("/breakfast")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest createBreakfast)
        {
            return Ok(createBreakfast);
        }

        [HttpGet("/breakfast/{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("/breakfast/{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, CreateBreakfastRequest createBreakfast)
        {
            return Ok(createBreakfast);
        }

        [HttpDelete("/breakfast/{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}
