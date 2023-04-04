using ELodowka.Api.Common.DTOs.Ingredients;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ELodowka.Api.Controllers;


[ApiController]
[Route("[controller]")]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _ingredientService;

    public IngredientController(IIngredientService ingredientService)
    {
        _ingredientService = ingredientService;
    }

    [HttpGet("{page:int}/{itemsPerPage:int}")]
    public async Task<ActionResult<List<IngredientDto>>> GetMany([FromRoute] int page, [FromRoute] int itemsPerPage)
    {
        var ingredients = await _ingredientService.GetMany();
        var totalCount = ingredients.Count;
        var totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);

        if (page < 1 || page > totalPages)
        {
            return BadRequest("Invalid page number");
        }

        var skip = (page - 1) * itemsPerPage;
        var take = itemsPerPage;

        var result = ingredients.Skip(skip).Take(take).ToList();

        return Ok(new 
        {
            totalPages,
            totalCount,
            result
        });
        
    }

    [HttpGet("GetAll")]

    public async Task<ActionResult<List<IngredientListDto>>> GetAll()
    {
        var ingredients = await _ingredientService.GetAll();
        
        return Ok(new 
        {
            ingredients
        });
        
    }
    
    [HttpPost]
    public async Task<ActionResult> Add([FromBody] IngredientDto model)
    {
        if (model == null) throw new ModelErrorException();
        if (model.Name.Length < 1) throw new ModelErrorException();
        if (model.Type.Length < 1) throw new ModelErrorException();

        await _ingredientService.Add(model);
        return Ok();
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult> Update([FromRoute] long id, [FromBody] IngredientDto model)
    {
        if (id < 0) throw new ModelErrorException();
        if (model == null) throw new ModelErrorException();
        if (model.Name.Length < 1) throw new ModelErrorException();
        if (model.Type.Length < 1) throw new ModelErrorException();
        await _ingredientService.Update(id, model);
        return Ok();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<IngredientDto>> Get([FromRoute] long id)
    {
        if (id < 0) throw new ModelErrorException();
        return await _ingredientService.Get(id);
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> Delete([FromRoute] long id)
    {
        if (id < 0) throw new ModelErrorException();
        await _ingredientService.Delete(id);
        return Ok();
    }
}