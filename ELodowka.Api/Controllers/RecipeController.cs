using ELodowka.Api.Common.Dto;
using ELodowka.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELodowka.Api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
    private readonly  IRecipeService _recipeService;

    public RecipeController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<List<RecipeDto>>> GetMany()
    {
        return await _recipeService.GetMany();
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] RecipeDto model)
    {
        await _recipeService.Add(model);
        return Ok();
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult> Update([FromRoute] long id, [FromBody] RecipeDto model)
    {
        await _recipeService.Update(id, model);
        return Ok();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<RecipeDto>> Get([FromRoute] long id)
    {
        return await _recipeService.Get(id);
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> Delete([FromRoute] long id)
    {
        await _recipeService.Delete(id);
        return Ok();
    }
    
}