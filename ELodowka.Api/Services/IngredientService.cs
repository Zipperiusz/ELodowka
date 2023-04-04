using AutoMapper;
using ELodowka.Api.Common.DTOs.Ingredients;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Users;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Api.Services;

public class IngredientService : IIngredientService
{
    private readonly ApplicationDbContext _context;
    private readonly IIngredientRepository _ingredientRepository;
    private readonly IMapper _mapper;
    private readonly IRequestUserService _requestUserService;

    public IngredientService(
        IMapper mapper,
        IIngredientRepository ingredientRepository,
        ApplicationDbContext context,
        IRequestUserService requestUserService)
    {
        _mapper = mapper;
        _ingredientRepository = ingredientRepository;
        _context = context;
        _requestUserService = requestUserService;
    }


    public async Task<List<IngredientDto>> GetMany()
    {
        var response = new ServiceResponse<List<IngredientDto>>();
        var dbIngredients = await _context.Ingredients.ToListAsync();
        response.Data = dbIngredients.Select(c => _mapper.Map<IngredientDto>(c)).ToList();
        return response.Data;
    }

    public async Task<List<IngredientListDto>> GetAll()
    {
        var response = new ServiceResponse<List<IngredientListDto>>();
        var dbIngredients = await _context.Ingredients.ToListAsync();
        response.Data = dbIngredients.Select(c => _mapper.Map<IngredientListDto>(c)).ToList();
        return response.Data;
    }

    public async Task Add(IngredientDto model)
    {
        if (model.Name.Length < 3 || model.Name.Length > 255)
        {
            throw new ModelErrorException();
        }
            
        
        var entity = _mapper.Map<Ingredient>(model);

        await _ingredientRepository.Add(entity);
    }

    public async Task Update(long id, IngredientDto data)
    {
        var entity = await _ingredientRepository.Get(id);
        if (entity == null)
        {
            throw new NotFoundException();
        }

        entity = _mapper.Map(data, entity);
        await _ingredientRepository.Update(entity);
    }

    public async Task<IngredientDto> Get(long id)
    {
        var data = await _ingredientRepository.Get<IngredientDto>(id);

        if (data == null)
        {
            throw new NotFoundException();
        }

        return data;
    }

    public async Task Delete(long id)
    {
        await _ingredientRepository.Delete(id);
    }
}