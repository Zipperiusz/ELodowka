﻿using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipes;

namespace ELodowka.Data.Users;

public class User : IEntity
{
    public long Id { get; set;}
    public byte[] PasswordHash { get; set; } 
    public byte[] PasswordSalt { get; set;}
    public string Email { get; set; }
    public List<Ingredient> IngredientsList { get; set; }
    public List<Recipe> RecipesList { get; set; }
}