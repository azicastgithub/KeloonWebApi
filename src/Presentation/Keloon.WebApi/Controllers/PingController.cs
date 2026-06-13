using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Keloon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPing()
        {
            return Ok(new
            {
                Status = "Healthy",
                Message = "Keloon API is up and running!",
                Timestamp = DateTime.UtcNow
            });
        }
    }
}
