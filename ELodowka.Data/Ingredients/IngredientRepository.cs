namespace ELodowka.Data.Ingredients;
using AutoMapper;

public class IngredientRepository : BaseRepository<Ingredient>, IIngredientRepository
{
    public IngredientRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}