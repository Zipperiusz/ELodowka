using System.Text.RegularExpressions;
using ELodowka.Api.Common.DTOs.Users;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data.Users;
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
        EnsureStrongPassword(request.Password);
        var user = new User();
        user.Email = request.Email;
        var response = await _authRepository.Register(user, request.Password);
        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }
    
    private void EnsureStrongPassword(string password)
    {
        if (password.Length < 8)
        {
            throw new TooShortPasswordException();
        }

        if (Regex.Match(password, @"[0-9]").Success == false)
        {
            throw new PasswordWithoutNumberException();
        }
    }

}