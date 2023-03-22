using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCommand : ICommand
{
    private float amount;

    public HealCommand(float amount)
    {
        this.amount = amount;
    }

    public void Execute(GameObject gameObject)
    {
        // Heal the player by amount
        Debug.Log("Healed");
    }
}