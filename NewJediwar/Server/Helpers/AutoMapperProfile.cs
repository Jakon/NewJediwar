using AutoMapper;
using NewJediwar.Shared.Dto.Requests;
using NewJediwar.Shared.Dto.Responses;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Server.Helpers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Player, LoginResponse>();

        CreateMap<RegisterRequest, Player>();
    }
}
