using Microsoft.AspNetCore.Components;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Client.Services;

public interface IPlanetService
{
    Task<IList<Planet>> GetAll();
}

public class PlanetService : IPlanetService
{
    private IHttpService _httpService;

    public PlanetService(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<IList<Planet>> GetAll()
    {
        return await _httpService.Get<IList<Planet>>("/planets/all");
    }
}
