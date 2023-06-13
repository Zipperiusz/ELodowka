using ELodowka.Api.Common;

namespace ELodowka.Api.Services;

public interface IRequestUserService
{
    bool IsLoggedIn();
    LoggedUserData GetData();
    long GetId();
    string GetEmail();
}