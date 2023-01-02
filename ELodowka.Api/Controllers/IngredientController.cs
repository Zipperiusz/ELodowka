using System.Security.Claims;
using ELodowka.Api.Common.Dto;
using ELodowka.Api.Services;
using ELodowka.Data.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELodowka.Api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class IngredientController : ControllerBase
{
    private readonly  IIngredientService _ingredientService;

    public IngredientController(IIngredientService ingredientService)
    {
        _ingredientService = ingredientService;
    }

    [HttpGet]
    public async Task<List<IngredientDto>> GetMany()
    {
        return await _ingredientService.GetMany();
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] IngredientDto model)
    {
        await _ingredientService.Add(model);
        return Ok();
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult> Update([FromRoute] long id, [FromBody] IngredientDto model)
    {
        await _ingredientService.Update(id, model);
        return Ok();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<IngredientDto>> Get([FromRoute] long id)
    {
        return await _ingredientService.Get(id);
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> Delete([FromRoute] long id)
    {
        await _ingredientService.Delete(id);
        return Ok();
    }
    
}