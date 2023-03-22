using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Toppings = new List<string> { "Cheese" };
        Price = 10.0m;
    }
}

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni Pizza";
        Toppings = new List<string> { "Pepperoni", "Cheese" };
        Price = 55.0m;
    }
}

public class VeggiePizza : Pizza
{
    public VeggiePizza()
    {
        Name = "Veggie Pizza";
        Toppings = new List<string> { "Mushrooms", "Peppers", "Onions", "Cheese" };
        Price = 1000.0m;
    }
}
