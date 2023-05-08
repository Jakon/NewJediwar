using Microsoft.AspNetCore.Components;
using NewJediwar.Shared.Dto.Requests;
using NewJediwar.Shared.Dto.Responses;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Client.Services;

public interface IPlayerService
{
    LoginResponse Player { get; }
    Task Initialize();
    Task Login(LoginRequest model);
    Task Logout();
    Task Register(RegisterRequest model);
    Task<IList<Player>> GetAll();
    Task<Player> GetById(string id);
    Task Update(string id, RegisterRequest model);
    Task Delete(string id);
}

public class PlayerService : IPlayerService
{
    private IHttpService _httpService;
    private NavigationManager _navigationManager;
    private ILocalStorageService _localStorageService;
    private string _userKey = "player";

    public LoginResponse Player { get; private set; }

    public PlayerService(IHttpService httpService, NavigationManager navigationManager, ILocalStorageService localStorageService)
    {
        _httpService = httpService;
        _navigationManager = navigationManager;
        _localStorageService = localStorageService;
    }

    public async Task Initialize()
    {
        Player = await _localStorageService.GetItem<LoginResponse>(_userKey);
    }

    public async Task Login(LoginRequest model)
    {
        Player = await _httpService.Post<LoginResponse>("/players/login", model);
        await _localStorageService.SetItem(_userKey, Player);
    }

    public async Task Logout()
    {
        Player = null;
        await _localStorageService.RemoveItem(_userKey);
        _navigationManager.NavigateTo("");
    }

    public async Task Register(RegisterRequest model)
    {
        await _httpService.Post("/players/register", model);
    }

    public async Task<IList<Player>> GetAll()
    {
        return await _httpService.Get<IList<Player>>("/players");
    }

    public async Task<Player> GetById(string id)
    {
        return await _httpService.Get<Player>($"/players/{id}");
    }

    public async Task Update(string id, RegisterRequest model)
    {
        await _httpService.Put($"/players/{id}", model);

        // update stored user if the logged in user updated their own record
        if (id == Player.Id.ToString())
        {
            // update local storage
            Player.Login = model.Login;
            await _localStorageService.SetItem(_userKey, Player);
        }
    }

    public async Task Delete(string id)
    {
        await _httpService.Delete($"/players/{id}");

        // auto logout if the logged in user deleted their own record
        if (id == Player.Id.ToString())
            await Logout();
    }
}
