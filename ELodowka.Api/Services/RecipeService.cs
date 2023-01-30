using System.Security.Claims;
using AutoMapper;
using ELodowka.Api.Common.Dto;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data;
using ELodowka.Data.Recipes;
using ELodowka.Data.Users;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Api.Services;

public class RecipeService : IRecipeService
{
    private readonly IMapper _mapper;
    private readonly  IRecipeRepository _recipeRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ApplicationDbContext _context;

    public RecipeService(IMapper mapper, IRecipeRepository recipeRepository, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
    {
        _mapper = mapper;
        _recipeRepository = recipeRepository;
        _httpContextAccessor = httpContextAccessor;
        _context = context;
    }
    
    private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User
        .FindFirstValue(ClaimTypes.NameIdentifier));

    public async Task<List<RecipeDto>> GetMany()
    {
        return await _recipeRepository.GetMany<RecipeDto>();
    }

    public async Task<ServiceResponse<UserDto>> Add(RecipeDto model)
    {

        ServiceResponse<UserDto> response = new ServiceResponse<UserDto>();
        try
        {
            User user = await _context.Users.FirstOrDefaultAsync(c =>
                c.Id == model.UserId && c.Id ==
                int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));
            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found";
                return response;
            }

            model.UserId = user.Id;

        }
        catch (Exception ex)
        {
            response.Success = false;
            response.Message = ex.Message;
        }
        var entity = _mapper.Map<Recipe>(model);
        
        await _recipeRepository.Add(entity);
        
        return response;
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