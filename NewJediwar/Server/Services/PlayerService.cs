using AutoMapper;
using NewJediwar.Server.Helpers;
using NewJediwar.Server.Middlewares.Jwt;
using NewJediwar.Shared.Dto.Requests;
using NewJediwar.Shared.Dto.Responses;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Server.Services;

public interface IPlayerService
{
    LoginResponse Authenticate(LoginRequest model);
    IEnumerable<Player> GetAll();
    Player GetById(Guid id);
    void Register(RegisterRequest model);
    //void Update(int id, UpdateRequest model);
    void Delete(Guid id);
}

public class PlayerService : IPlayerService
{
    private DataContext _context;
    private IJwtUtils _jwtUtils;
    private readonly IMapper _mapper;

    public PlayerService(DataContext context, IJwtUtils jwtUtils, IMapper mapper)
    {
        _context = context;
        _jwtUtils = jwtUtils;
        _mapper = mapper;
    }

    public LoginResponse Authenticate(LoginRequest model)
    {
        var player = _context.Players.SingleOrDefault(x => x.Login == model.Login);

        // validate		
        if (player == null || !BCrypt.Net.BCrypt.Verify(model.Password, player.PasswordHash))
            throw new AppException("playername or password is incorrect");

        // authentication successful
        var response = _mapper.Map<LoginResponse>(player);
        response.Token = _jwtUtils.GenerateToken(player);
        return response;
    }

    public IEnumerable<Player> GetAll()
    {
        return _context.Players;
    }

    public Player GetById(Guid id)
    {
        return getPlayer(id);
    }

    public void Register(RegisterRequest model)
    {
        // validate
        if (_context.Players.Any(x => x.Login == model.Login))
            throw new AppException("playername '" + model.Login + "' is already taken");

        // map model to new player object
        var player = _mapper.Map<Player>(model);

        // hash password
        player.PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);

        // save player
        _context.Players.Add(player);
        _context.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var player = getPlayer(id);
        _context.Players.Remove(player);
        _context.SaveChanges();
    }

    // helper methods

    private Player getPlayer(Guid id)
    {
        var player = _context.Players.Find(id);
        if (player == null) throw new KeyNotFoundException("Player not found");
        return player;
    }
}