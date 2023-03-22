using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAbility : ICharacterVisitor
{
    public void Visit(Wizard wizard)
    {
        wizard.Shield();
    }

    public void Visit(Knight knight)
    {
        knight.RaiseShield();
    }

    public void Visit(Thief thief)
    {
        // Thieves cannot use a shield
    }
}