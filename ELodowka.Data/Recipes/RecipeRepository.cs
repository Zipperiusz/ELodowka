using AutoMapper;

namespace ELodowka.Data.Recipes;

public class RecipeRepository: BaseRepository<Recipe>, IRecipeRepository
{
    public RecipeRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}