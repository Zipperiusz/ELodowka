using AutoMapper;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Api.Common.DTOs.Step;
using ELodowka.Data.RecipeIngredients;
using ELodowka.Data.Recipes;
using ELodowka.Data.Steps;

namespace ELodowka.Api.Common.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDto>()
            .ForMember(dist => dist.Ingredients, opt => opt.MapFrom(src => src.RecipeIngredients))
            .ReverseMap();
        CreateMap<RecipeIngredient, RecipeIngredientDto>()
            .ForMember(dist => dist.Name, opt => opt.MapFrom(src => src.Ingredient.Name));
        CreateMap<RecipeAddDto, Recipe>();
        CreateMap<RecipeUpdateDto, Recipe>();
        CreateMap<Step, StepDto>();
    }
}