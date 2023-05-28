using Microsoft.AspNetCore.Mvc;

namespace Scheduler.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SchedulerController : ControllerBase
    {
        [HttpGet("is-alive")]
        public IActionResult IsAlive()
        {
            return Ok(true);
        }
    }
}
