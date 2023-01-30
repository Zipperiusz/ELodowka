using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Data.Recipes;

namespace ELodowka.Api.Common.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDto>().ReverseMap();
    }
}