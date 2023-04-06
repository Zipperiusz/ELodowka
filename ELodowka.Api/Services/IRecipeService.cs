using ELodowka.Api.Common.DTOs;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Api.Common.DTOs.Users;
using ELodowka.Data.Users;

namespace ELodowka.Api.Services;

public interface IRecipeService
{
    Task<List<RecipeDto>> GetMany();

    Task<List<RecipeDto>> GetFound();

    Task<ServiceResponse<AddUpdateDto>> Add(RecipeAddDto model);
    Task Update(long id, RecipeUpdateDto data);
    Task<RecipeDto> Get(long id);
    Task Delete(long id);
}