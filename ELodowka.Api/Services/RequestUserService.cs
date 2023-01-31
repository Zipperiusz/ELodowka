using System.Security.Claims;
using ELodowka.Api.Common;
using ELodowka.Api.Common.Exceptions;

namespace ELodowka.Api.Services;

public class RequestUserService : IRequestUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public RequestUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public bool IsLoggedIn()
    {
        return _httpContextAccessor.HttpContext?.User != null;
    }

    public LoggedUserData GetData()
    {
        if (!IsLoggedIn())
        {
            throw new NotAuthorizedException();
        }

        var claims = _httpContextAccessor.HttpContext!.User.Claims;

        return new LoggedUserData
        {
            Id = GetId(),
            Email = GetName()
        };
    }

    public long GetId()
    {
        return long.Parse(
            _httpContextAccessor.HttpContext!.User.Claims
                .Where(claim => claim.Type == ClaimTypes.NameIdentifier)
                .Select(claim => claim.Value)
                .FirstOrDefault()!
        );
    }

    public string GetName()
    {
        return
            _httpContextAccessor.HttpContext!.User.Claims
                .Where(claim => claim.Type == ClaimTypes.Name)
                .Select(claim => claim.Value)
                .FirstOrDefault()!;
    }
}