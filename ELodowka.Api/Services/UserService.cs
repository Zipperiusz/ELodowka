using System.Text.RegularExpressions;
using AutoMapper;

using ELodowka.Api.Common.Dto;
using ELodowka.Api.Common.Exceptions;
using ELodowka.Data.User;

namespace ELodowka.Api.Services;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<UserDto>> GetMany()
    {
        return await _userRepository.GetMany<UserDto>();
    }

    public async Task Add(UserDto model)
    {
        EnsureStrongPassword(model.Password);
        var entity = _mapper.Map<User>(model);

        entity.Password = CreateStrongPassword(entity.Password);
        await _userRepository.Add(entity);
    }

    private void EnsureStrongPassword(string password)
    {
        if (password.Length < 8)
        {
            // throw exception
        }

        if (Regex.Match(password, @"[0-9]").Success == false)
        {
            // throw exception
        }
    }

    private string CreateStrongPassword(string password)
    {
        throw new NotImplementedException();
    }

    public async Task Update(long id, UserDto data)
    {
        var entity = await _userRepository.Get(id);
        if (entity == null) throw new NotFoundException();

        entity = _mapper.Map(data, entity);
        await _userRepository.Update(entity);
    }

    public async Task<UserDto> Get(long id)
    {
        var data = await _userRepository.Get<UserDto>(id);

        if (data == null) throw new NotFoundException();

        return data;
    }

    public async Task Delete(long id)
    {
        await _userRepository.Delete(id);
    }
    
}