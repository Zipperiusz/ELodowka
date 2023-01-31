using AutoMapper;

namespace ELodowka.Data.Ingredients;

public class IngredientRepository
    : BaseRepository<Ingredient>,
        IIngredientRepository
{
    public IngredientRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}