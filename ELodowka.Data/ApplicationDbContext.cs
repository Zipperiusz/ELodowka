using ELodowka.Data.Ingredients;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<User.User> Users => Set<User.User>();
    public DbSet<Recipe.Recipe> Recipes => Set<Recipe.Recipe>();
    public DbSet<Ingredients.Ingredient> Ingredients => Set<Ingredients.Ingredient>();
    
    
}