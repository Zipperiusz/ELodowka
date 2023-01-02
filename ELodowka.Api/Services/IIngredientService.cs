﻿using ELodowka.Api.Common.Dto;

namespace ELodowka.Api.Services;

public interface IIngredientService
{
    Task<List<IngredientDto>> GetMany();
    Task Add(IngredientDto model);
    Task Update(long id, IngredientDto data);
    Task<IngredientDto> Get(long id);
    Task Delete(long id);
}