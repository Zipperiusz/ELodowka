using ELodowka.Api.Common.DTOs.Users;

namespace ELodowka.Api.Services;

public interface IUserService
{
    Task<List<UserDto>> GetMany();
    Task Add(UserDto model);
    Task Update(long id, UserDto data);
    Task<UserDto> Get(long id);
    Task Delete(long id);
}