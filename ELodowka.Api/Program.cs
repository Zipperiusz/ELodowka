using Microsoft.EntityFrameworkCore;
using ELodowka.Api.Common.Profiles;
using ELodowka.Api.Services;
using ELodowka.Data;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipe;
using ELodowka.Data.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(opt => { opt.AddProfile<UserProfile>(); });
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(opt => { opt.AddProfile<RecipeProfile>(); });
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddAutoMapper(opt => { opt.AddProfile<IngredientProfile>(); });
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IIngredientService, IngredientService>();


builder.Services.AddDbContext<ApplicationDbContext>(opt => opt
    .UseInMemoryDatabase("Lodowka")    
    // .UseSqlite(@"Data Source=..\baza.db", b => b.MigrationsAssembly("ELodowka.Api"))
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();