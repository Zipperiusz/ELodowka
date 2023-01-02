using ELodowka.Api.Common.Dto;
using ELodowka.Data.User;
using Microsoft.AspNetCore.Mvc;

namespace ELodowka.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthRepository _authRepository;
    public AuthController(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    [HttpPost("login")]
    public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
    {
        var response = await _authRepository.Login(request.Email, request.Password);
        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }
    
    [HttpPost("register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
    {
        User user = new User();
        user.Email = request.Email;
        var response = await _authRepository.Register(user,request.Password);
        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }
}