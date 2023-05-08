using Microsoft.AspNetCore.Mvc;
using NewJediwar.Server.Authorization;
using NewJediwar.Server.Services;
using NewJediwar.Shared.Dto.Requests;

namespace NewJediwar.Server.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
    private IPlayerService _playerService;

    public PlayersController(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public IActionResult Authenticate(LoginRequest model)
    {
        var response = _playerService.Authenticate(model);
        return Ok(response);
    }

    [AllowAnonymous]
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest model)
    {
        _playerService.Register(model);
        return Ok(new { message = "Registration successful" });
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _playerService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var user = _playerService.GetById(id);
        return Ok(user);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _playerService.Delete(id);
        return Ok(new { message = "User deleted successfully" });
    }
}