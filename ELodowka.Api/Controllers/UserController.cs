using ELodowka.Api.Common.Dto;
using ELodowka.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ELodowka.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDto>>> GetMany()
    {
        return await _userService.GetMany();
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] UserDto model)
    {
        await _userService.Add(model);
        return Ok();
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult> Update([FromRoute] long id, [FromBody] UserDto model)
    {
        await _userService.Update(id, model);
        return Ok();
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<UserDto>> Get([FromRoute] long id)
    {
        return await _userService.Get(id);
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> Delete([FromRoute] long id)
    {
        await _userService.Delete(id);
        return Ok();
    }
    
}