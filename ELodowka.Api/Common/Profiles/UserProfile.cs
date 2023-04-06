using AutoMapper;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Api.Common.DTOs.Users;
using ELodowka.Data.Users;

namespace ELodowka.Api.Common.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, UserRecipeDto>().ReverseMap();
    }
}