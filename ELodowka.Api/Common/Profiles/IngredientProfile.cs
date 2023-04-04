using AutoMapper;
using ELodowka.Api.Common.DTOs.Ingredients;
using ELodowka.Data.Ingredients;

namespace ELodowka.Api.Common.Profiles;

public class IngredientProfile : Profile
{
    public IngredientProfile()
    {
        CreateMap<Ingredient, IngredientDto>().ReverseMap();
        CreateMap<Ingredient,IngredientListDto>();
    }
}