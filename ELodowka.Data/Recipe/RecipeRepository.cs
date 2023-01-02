using AutoMapper;

namespace ELodowka.Data.Recipe;

public class RecipeRepository: BaseRepository<Recipe>, IRecipeRepository
{
    public RecipeRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}