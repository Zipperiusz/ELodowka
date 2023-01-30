using AutoMapper;

namespace ELodowka.Data.Timers;

public class TimerRepository: BaseRepository<Timer>, ITimerRepository
{
    public TimerRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}