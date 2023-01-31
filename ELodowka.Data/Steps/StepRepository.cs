using AutoMapper;

namespace ELodowka.Data.Steps;

public class StepRepository
    : BaseRepository<Step>,
        IStepRepository
{
    public StepRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}