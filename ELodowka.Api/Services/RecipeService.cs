using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data.Recipe;

namespace ELodowka.Api.Services;

public class RecipeService : IRecipeService
{
    private readonly IMapper _mapper;
    private readonly  IRecipeRepository _recipeRepository;

    public RecipeService(IMapper mapper, IRecipeRepository recipeRepository)
    {
        _mapper = mapper;
        _recipeRepository = recipeRepository;
    }

    public async Task<List<RecipeDto>> GetMany()
    {
        return await _recipeRepository.GetMany<RecipeDto>();
    }

    public async Task Add(RecipeDto model)
    {
        var entity = _mapper.Map<Recipe>(model);

        await _recipeRepository.Add(entity);
    }

    public async Task Update(long id, RecipeDto data)
    {
        var entity = await _recipeRepository.Get(id);
        if (entity == null) throw new NotFoundException();

        entity = _mapper.Map(data, entity);
        await _recipeRepository.Update(entity);
    }

    public async Task<RecipeDto> Get(long id)
    {
        var data = await _recipeRepository.Get<RecipeDto>(id);

        if (data == null) throw new NotFoundException();

        return data;
    }

    public async Task Delete(long id)
    {
        await _recipeRepository.Delete(id);
    }
}