using AutoMapper;

namespace ELodowka.Data.Timer;

public class TimerRepository: BaseRepository<Timer>, ITimerRepository
{
    public TimerRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}