using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pizza
{
    public string Name { get; set; }
    public List<string> Toppings { get; set; }
    public decimal Price { get; set; }

    public void Bake()
    {
        // Code to bake the pizza
    }

    public void Cut()
    {
        // Code to cut the pizza
    }

    public void Box()
    {
        // Code to box the pizza
    }

    public void Print()
    {
        Debug.Log("Name:" + ":" + Name + " Price:" + Price);
        string pizzaToppings = "";
        foreach (string extra in Toppings)
        {
            pizzaToppings += extra + ",";
        }
        Debug.Log("Toppings: " + pizzaToppings);
    }
}
