using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Print
{
    public void printRecipe()
    {
        //Instantiating a class object of POE Ingredient
        POEIngredient r = new POEIngredient();
        String enterKey;

        do
        {

            Console.WriteLine("1. ADD INGREDIENT(S)");
            Console.WriteLine("2. ADD INSTRUCTION(S)");
            Console.WriteLine("3. DISPLAY");
            Console.WriteLine("4. SCALE RECIPE");
            Console.WriteLine("5. RESET QUANTITIES");
            Console.WriteLine("6. CLEAR RECIPE");
            Console.WriteLine("0. EXIT");

            Console.Write("\nEnter a key: ");
            enterKey = Console.ReadLine();

            switch (enterKey)
            {
                case "1":
                    Console.Write("Enter the number of ingredients: ");
                    int ingredientCount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < ingredientCount; i++)
                    {
                        Console.Write($"Enter ingredient {i + 1} name: ");
                        string name = Console.ReadLine();

                        Console.Write($"Enter ingredient {i + 1} quantity: ");
                        double quantity = double.Parse(Console.ReadLine());

                        Console.Write($"Enter ingredient {i + 1} unit: ");
                        string unit = Console.ReadLine();

                        Recipe ingredient = new Recipe(name, quantity, unit);
                        r.AddIngredient(ingredient);
                    }

                    r.SaveOriginalQuantities();
                    break;

                case "2":
                    Console.Write("Enter step description: ");
                    string step = Console.ReadLine();

                    r.AddStep(step);
                    break;

                case "3":
                    r.Display();
                    break;

                case "4":
                    Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                    double factor = double.Parse(Console.ReadLine());


                    r.Scale(factor);
                    break;

                case "5":
                    r.ResetQuantities();
                    break;

                case "6":
                    r.Clear();
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("Invalid key.");
                    break;
            }

        } while (enterKey != "0");
    }
}
  
