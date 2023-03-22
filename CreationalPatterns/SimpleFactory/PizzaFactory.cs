using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class PizzaFactory
{
    public static Pizza CreatePizza(string pizzaType)
    {
        switch (pizzaType.ToLower())
        {
            case "cheese":
                return new CheesePizza();
            case "pepperoni":
                return new PepperoniPizza();
            case "veggie":
                return new VeggiePizza();
            default:
                throw new System.ArgumentException($"Invalid pizza type: {pizzaType}");
        }
    }
}
