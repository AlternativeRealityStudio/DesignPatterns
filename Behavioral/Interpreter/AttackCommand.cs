using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommand : ICommand
{
    private GameObject target;

    public AttackCommand(GameObject target)
    {
        this.target = target;
    }

    public void Execute(GameObject gameObject)
    {
        // Attack the target
        Debug.Log("Attack the enemy");
    }
}
