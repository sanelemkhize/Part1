using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Recipe
{
    //Ingredient variables
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }

    //Constructor for a recipe class
    public Recipe(string name, double quantity, string unit)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }

    //A scale method to calculate quantities
    public void Scale(double factor)
    {
        Quantity *= factor;
    }


    public override string ToString()
    {
        return $"{Quantity} {Unit} of {Name}";
    }
}
