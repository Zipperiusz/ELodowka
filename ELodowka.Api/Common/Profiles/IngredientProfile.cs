using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Data.Ingredients;

namespace ELodowka.Api.Common.Profiles;

public class IngredientProfile : Profile
{
    public IngredientProfile()
    {
        CreateMap<Ingredient, IngredientDto>().ReverseMap();
    }
}