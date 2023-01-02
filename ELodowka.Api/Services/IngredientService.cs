﻿using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipe;

namespace ELodowka.Api.Services;

public class IngredientService : IIngredientService
{
    private readonly IMapper _mapper;
    private readonly  IIngredientRepository _ingredientRepository;

    public IngredientService(IMapper mapper, IIngredientRepository ingredientRepository)
    {
        _mapper = mapper;
        _ingredientRepository = ingredientRepository;
    }

    public async Task<List<IngredientDto>> GetMany()
    {
        return await _ingredientRepository.GetMany<IngredientDto>();
    }

    public async Task Add(IngredientDto model)
    {
        var entity = _mapper.Map<Ingredient>(model);

        await _ingredientRepository.Add(entity);
    }

    public async Task Update(long id, IngredientDto data)
    {
        var entity = await _ingredientRepository.Get(id);
        if (entity == null) throw new NotFoundException();

        entity = _mapper.Map(data, entity);
        await _ingredientRepository.Update(entity);
    }

    public async Task<IngredientDto> Get(long id)
    {
        var data = await _ingredientRepository.Get<IngredientDto>(id);

        if (data == null) throw new NotFoundException();

        return data;
    }

    public async Task Delete(long id)
    {
        await _ingredientRepository.Delete(id);
    }
}