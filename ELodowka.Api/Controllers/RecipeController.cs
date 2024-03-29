﻿using ELodowka.Api.Common.DTOs;
using ELodowka.Api.Common.DTOs.Recipes;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Api.Services;
using ELodowka.Data.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELodowka.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly IRecipeService _recipeService;
    private readonly IRequestUserService _requestUserService;


    public RecipeController(IRecipeService recipeService, IRequestUserService requestUserService)
    {
        _recipeService = recipeService;
        _requestUserService = requestUserService;
    }

    [HttpGet("{page:int}/{itemsPerPage:int}")]
    public async Task<ActionResult<List<RecipeDto>>> GetMany([FromRoute] int page, [FromRoute] int itemsPerPage)
    {
        var recipes = await _recipeService.GetMany();
        var totalCount = recipes.Count;
        var totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);

        if (page < 1 || page > totalPages)
        {
            return BadRequest("Invalid page number");
        }

        var skip = (page - 1) * itemsPerPage;
        var take = itemsPerPage;

        var result = recipes.Skip(skip).Take(take).ToList();

        return Ok(
            new
            {
                totalPages,
                totalCount,
                result
            });
    }
    [Authorize]
    [HttpPost("UserRecipes")]
    public async Task<ActionResult<List<RecipeDto>>> GetUserRecipes()
    {
        var recipes = await _recipeService.GetUserRecipes();

        return Ok(
            recipes);
    }

    [HttpPost("WithIngredients")]
    public async Task<ActionResult<ServiceResponse<List<RecipeDto>>>> GetRecipesWithAllIngredients(
        [FromBody] List<string> ingredients,
        [FromQuery] int page,
        [FromQuery] int itemsPerPage)
    {
        var recipes = await _recipeService.GetMany();


        var filteredRecipes = recipes.Where(
            r =>
                r.Ingredients.All(i => ingredients.Any(ing => ing.Equals(i.Name, StringComparison.OrdinalIgnoreCase)))
        );


        var recipeDtos = filteredRecipes.ToList();
        var totalCount = recipeDtos.Count();
        var totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);

        if (page < 1 || page > totalPages)
        {
            return BadRequest("Invalid page number");
        }

        var skip = (page - 1) * itemsPerPage;
        var take = itemsPerPage;

        var result = recipeDtos
            .Skip(skip)
            .Take(take)
            .Select(
                r => new RecipeDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Steps = r.Steps,
                    ImageUrl = r.ImageUrl,
                    Description = r.Description,
                    Ingredients = r.Ingredients,

                    User = r.User
                });

        return Ok(
            new
            {
                totalPages,
                totalCount,
                result
            });
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<AddUpdateDto>>> Add([FromBody] RecipeAddDto model)
    {
        if (model.Name.Length < 2) throw new ModelErrorException();
        if (model.Ingredients.Count < 1) throw new ModelErrorException();
        if (model.Steps.Count < 1) throw new ModelErrorException();


        return await _recipeService.Add(model);
    }

    [Authorize]
    [HttpPut("{id:long}")]
    public async Task<ActionResult> Update([FromRoute] long id, [FromBody] RecipeUpdateDto model)
    {
        if (id < 0) throw new ModelErrorException();
        if (model.Name.Length < 2) throw new ModelErrorException();
        if (model.Ingredients.Count < 1) throw new ModelErrorException();
        if (model.Steps.Count < 1) throw new ModelErrorException();
        await _recipeService.Update(id, model);
        return Ok();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<RecipeDto>> Get([FromRoute] long id)
    {
        if (id < 0) throw new ModelErrorException();

        return await _recipeService.Get(id);
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> Delete([FromRoute] long id)
    {
        if (id < 0) throw new ModelErrorException();
        await _recipeService.Delete(id);
        return Ok();
    }
}