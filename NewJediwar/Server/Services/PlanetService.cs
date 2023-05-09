using NewJediwar.Server.Helpers;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Server.Services;

public interface IPlanetService
{
    IEnumerable<Planet> GetAll();
}

public class PlanetService : IPlanetService
{
    private DataContext _context;

    public PlanetService(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Planet> GetAll()
    {
        return _context.Planets;
    }
}
