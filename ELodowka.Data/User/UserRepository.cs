using AutoMapper;

namespace ELodowka.Data.User;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}