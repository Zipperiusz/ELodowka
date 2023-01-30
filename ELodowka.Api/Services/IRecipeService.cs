using ELodowka.Api.Common.Dto;
using ELodowka.Data.Users;

namespace ELodowka.Api.Services;

public interface IRecipeService
{
    Task<List<RecipeDto>> GetMany();
    Task<ServiceResponse<UserDto>> Add(RecipeDto model);
    Task Update(long id, RecipeDto data);
    Task<RecipeDto> Get(long id);
    Task Delete(long id);
    
}