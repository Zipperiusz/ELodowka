using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipes;
using ELodowka.Data.Users;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Recipe> Recipes => Set<Recipe>();
    public DbSet<Ingredient> Ingredients => Set<Ingredient>();
    
    
}