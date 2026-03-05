
using System;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");

        foreach (var item in Ingredients)
        {
            Console.WriteLine($"- {item.Name}: {item.Amount}{item.Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        Ingredient[] newIngredients = Ingredients;

        for (int i = 0; i < newIngredients.Length; i++)
        {
            newIngredients[i].Amount *= (double)newServings / Servings;
        }

        return new RecipeCard(Name, newServings, newIngredients);
    }
}