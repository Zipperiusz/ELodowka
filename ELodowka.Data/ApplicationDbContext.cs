using ELodowka.Data.Extensions;
using ELodowka.Data.Ingredients;
using ELodowka.Data.RecipeIngredients;
using ELodowka.Data.Recipes;
using ELodowka.Data.Steps;
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
    public DbSet<Step> Steps => Set<Step>();
    public DbSet<RecipeIngredient> RecipeIngredients => Set<RecipeIngredient>();
    public DbSet<Ingredient> Ingredients => Set<Ingredient>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.SeedDatabase();
    }
}