using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Data.Users;

namespace ELodowka.Api.Common.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}