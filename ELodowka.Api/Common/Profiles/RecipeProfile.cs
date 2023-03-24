using AutoMapper;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Api.Common.DTOs.Step;
using ELodowka.Data.Recipes;
using ELodowka.Data.Steps;

namespace ELodowka.Api.Common.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDto>().ReverseMap();
        CreateMap<RecipeAddDto, Recipe>();
        CreateMap<RecipeUpdateDto, Recipe>();
        CreateMap<Step, StepDto>();
    }
}