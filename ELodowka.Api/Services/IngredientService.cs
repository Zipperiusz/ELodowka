using System.Security.Claims;
using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Users;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Api.Services;

public class IngredientService : IIngredientService
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _context;
    private readonly  IIngredientRepository _ingredientRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public IngredientService(IMapper mapper, IIngredientRepository ingredientRepository, ApplicationDbContext context,
        IHttpContextAccessor httpContextAccessor)
    {
        _mapper = mapper;
        _ingredientRepository = ingredientRepository;
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }


    public async Task<List<IngredientDto>> GetMany()
    {
        var response = new ServiceResponse<List<IngredientDto>>();
        var dbIngredients = await _context.Ingredients.ToListAsync();
        response.Data = dbIngredients.Select(c => _mapper.Map<IngredientDto>(c)).ToList();
        return response.Data;
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