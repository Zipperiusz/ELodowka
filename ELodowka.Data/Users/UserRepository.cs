using AutoMapper;

namespace ELodowka.Data.Users;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}