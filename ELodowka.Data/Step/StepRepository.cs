using AutoMapper;

namespace ELodowka.Data.Step;

public class StepRepository: BaseRepository<Step>, IStepRepository
{
    public StepRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}