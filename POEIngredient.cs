using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class POEIngredient
 {
    //Declaring an Arraylist to store ingrediets and instructions
    public List<Recipe> Ingredients { get; set; }
    public List<string> Instructions { get; set; }

    private List<Recipe> originalIngredients;

    //Constructor methods for arrays
    public POEIngredient()
    {
        Ingredients = new List<Recipe>();
        Instructions = new List<string>();
    }

    //A method to add ingredient within a recipe
    public void AddIngredient(Recipe ingredient)
    {
        Ingredients.Add(ingredient);
    }

    //A method to also add instructions for a recipe
    public void AddStep(string step)
    {
        Instructions.Add(step);
    }

    //A method to display the entire recipe 
    public void Display()
    {
        Console.WriteLine("*************************************************************");
        Console.WriteLine("***                    MASON RECIPE                       ***");
        Console.WriteLine("*************************************************************");
        Console.WriteLine("INGREDIENTS: ");
        foreach (Recipe ingredient in Ingredients)
        {
            Console.WriteLine(ingredient.ToString());
        }
        Console.WriteLine("\n*************************************************************");
        Console.WriteLine("\nINSTRUCTIONS:");
        for (int i = 0; i < Instructions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Instructions[i]}");
        }
        Console.WriteLine("*************************************************************");
        Console.WriteLine("***                 MASON DINER KITCHEN                   ***");
        Console.WriteLine("*************************************************************");
    }

    //Method that scale or add the ingredient quantities and unit measurements
    public void Scale(double factor)
    {
        foreach (Recipe ingredient in Ingredients)
        {
            ingredient.Scale(factor);
        }
    }

    //Method which reset the entire recipe quantities
    public void ResetQuantities()
    {
        for (int i = 0; i < Ingredients.Count; i++)
        {
            Ingredients[i].Quantity = originalIngredients[i].Quantity;
        }
    }

    //Method that clears everything within the recipe
    public void Clear()
    {
        Ingredients.Clear();
        Instructions.Clear();
    }

    //A method that saves the original quantities from the recipe
    public void SaveOriginalQuantities()
    {
        originalIngredients = new List<Recipe>();
        foreach (Recipe ingredient in Ingredients)
        {
            originalIngredients.Add(new Recipe(ingredient.Name, ingredient.Quantity, ingredient.Unit));
        }
    }
}
