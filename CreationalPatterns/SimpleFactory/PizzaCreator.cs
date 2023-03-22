using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaCreator : MonoBehaviour
{
 
    void Start()
    {
        // Customer orders a cheese pizza
        Pizza pizzaCheese = PizzaFactory.CreatePizza("Cheese");
        pizzaCheese.Print();

        // Customer orders a pepperoni pizza
        Pizza pizzaPepperoni = PizzaFactory.CreatePizza("Pepperoni");
        pizzaPepperoni.Print();

        // Customer orders a veggie pizza
        Pizza pizzaVeggie = PizzaFactory.CreatePizza("Veggie");
        pizzaVeggie.Print();
    }
}
