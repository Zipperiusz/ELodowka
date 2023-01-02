using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipe;

namespace ELodowka.Api.Common.Profiles;

public class IngredientProfile : Profile
{
    public IngredientProfile()
    {
        CreateMap<Ingredient, IngredientDto>().ReverseMap();
    }
}