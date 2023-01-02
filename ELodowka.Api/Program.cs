using Microsoft.EntityFrameworkCore;
using ELodowka.Api.Common.Profiles;
using ELodowka.Api.Services;
using ELodowka.Data;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipe;
using ELodowka.Data.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme {
        Description = "Standard Authorization header using the Bearer scheme, e.g. \"bearer {token} \"",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    });
builder.Services.AddHttpContextAccessor();

builder.Services.AddAutoMapper(opt => { opt.AddProfile<UserProfile>(); });
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(opt => { opt.AddProfile<RecipeProfile>(); });
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddAutoMapper(opt => { opt.AddProfile<IngredientProfile>(); });
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IIngredientService, IngredientService>();

builder.Services.AddScoped<IAuthRepository, AuthRepository>();



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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();