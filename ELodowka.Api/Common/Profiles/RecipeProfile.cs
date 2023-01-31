using AutoMapper;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Data.Recipes;

namespace ELodowka.Api.Common.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDto>().ReverseMap();
        CreateMap<RecipeAddDto, Recipe>();
        CreateMap<RecipeUpdateDto, Recipe>();
    }
}