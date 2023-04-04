using ELodowka.Api.Common.DTOs.Ingredients;

namespace ELodowka.Api.Services;

public interface IIngredientService
{
    Task<List<IngredientDto>> GetMany();
    Task<List<IngredientListDto>> GetAll();
    Task Add(IngredientDto model);
    Task Update(long id, IngredientDto data);
    Task<IngredientDto> Get(long id);
    Task Delete(long id);
}