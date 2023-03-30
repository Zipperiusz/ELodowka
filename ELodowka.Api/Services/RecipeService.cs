using AutoMapper;
using ELodowka.Api.Common.DTOs;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data;
using ELodowka.Data.RecipeIngredients;
using ELodowka.Data.Recipes;
using ELodowka.Data.Steps;
using ELodowka.Data.Users;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Api.Services;

public class RecipeService : IRecipeService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IRecipeRepository _recipeRepository;
    private readonly IRequestUserService _requestUserService;

    public RecipeService(
        IMapper mapper,
        IRecipeRepository recipeRepository,
        IRequestUserService requestUserService,
        ApplicationDbContext context)
    {
        _mapper = mapper;
        _recipeRepository = recipeRepository;
        _requestUserService = requestUserService;
        _context = context;
    }

    public async Task<List<RecipeDto>> GetMany()
    {
        return await _recipeRepository.GetMany<RecipeDto>();
    }

    public async Task<List<RecipeDto>> GetFound()
    {
        var recipes = await _recipeRepository.GetMany<RecipeDto>();

        

        return recipes;
        
    }

    public async Task<RecipeDto> Get(long id)
    {
        var data = await _recipeRepository.Get<RecipeDto>(id);

        if (data == null)
        {
            throw new NotFoundException();
        }

        return data;
    }

    public async Task Delete(long id)
    {
        await _recipeRepository.Delete(id);
    }

    public async Task<ServiceResponse<AddUpdateDto>> Add(RecipeAddDto model)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var entity = _mapper.Map<Recipe>(model);
            entity.UserId = _requestUserService.GetId();
            await _recipeRepository.Add(entity);
            var stepId = _context.Steps.Count();
            foreach (var step in model.Steps)
            {
                step.Id = stepId;
                stepId++;
            }
            foreach (var ingredient in model.Ingredients)
            {
                await _context.RecipeIngredients.AddAsync(
                    new RecipeIngredient
                    {
                        IngredientId = ingredient.Id,
                        Quantity = ingredient.Quantity,
                        QuantityType = ingredient.QuantityType,
                        RecipeId = entity.Id
                    });
            }

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();

            return new ServiceResponse<AddUpdateDto>
            {
                Data = new AddUpdateDto
                {
                    Id = entity.Id
                }
            };
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task Update(long id, RecipeUpdateDto data)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var entity = await _context.Recipes
                .Include(recipe => recipe.RecipeIngredients)
                .Include(recipe => recipe.Steps)
                .Where(recipe => recipe.Id == id)
                .FirstOrDefaultAsync();
            
            if (entity == null)
            {
                throw new NotFoundException();
            }

            _context.RecipeIngredients.RemoveRange(entity.RecipeIngredients);
            _context.Steps.RemoveRange(entity.Steps);
            await _context.SaveChangesAsync();
            entity = _mapper.Map(data, entity);
            await _recipeRepository.Update(entity);
            foreach (var ingredient in data.Ingredients)
            {
                await _context.RecipeIngredients.AddAsync(
                    new RecipeIngredient
                    {
                        IngredientId = ingredient.Id,
                        Quantity = ingredient.Quantity,
                        QuantityType = ingredient.QuantityType,
                        RecipeId = entity.Id
                    });
            }

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}