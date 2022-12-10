using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Data.User;

namespace ELodowka.Api.Common.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}