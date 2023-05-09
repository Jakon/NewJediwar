using Microsoft.AspNetCore.Mvc;
using NewJediwar.Server.Authorization;
using NewJediwar.Server.Services;

namespace NewJediwar.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PlanetsController : ControllerBase
    {
        public IPlanetService _planetService { get; set; }

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [HttpGet("all")]        
        public IActionResult GetAll()
        {
            var planets = _planetService.GetAll();
            return Ok(planets);
        }
    }
}
