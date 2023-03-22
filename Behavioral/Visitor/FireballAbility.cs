using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAbility : ICharacterVisitor
{
    public void Visit(Wizard wizard)
    {
        wizard.CastFireball();
        Debug.Log("Wizard cast fireball");
    }

    public void Visit(Knight knight)
    {
        // Knights cannot cast fireball
        Debug.Log("Knight --------------");
    }

    public void Visit(Thief thief)
    {
        thief.ThrowFirebomb();
        Debug.Log("Thief Throw Bomb");
    }
}