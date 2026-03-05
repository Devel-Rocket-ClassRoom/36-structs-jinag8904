using System;

Ingredient[] ingredient =
{
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파", 1, "개"),
    new Ingredient("마늘", 3, "쪽")
};

RecipeCard card = new RecipeCard("토마토 파스타", 2, ingredient);

Console.WriteLine("=== 원본 레시피 ===");
card.PrintRecipe();

Console.WriteLine("\n=== 4인분으로 변환 ===");
card.ScaleRecipe(4).PrintRecipe();