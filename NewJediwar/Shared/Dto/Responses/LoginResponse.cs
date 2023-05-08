using NewJediwar.Shared.Entities;

namespace NewJediwar.Shared.Dto.Responses;

public class LoginResponse : Player
{
    public string Token { get; set; }
}
