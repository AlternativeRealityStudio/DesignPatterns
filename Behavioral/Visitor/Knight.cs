using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : VCharacter
{
    public override void Accept(ICharacterVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void RaiseShield()
    {
        // Raise the character's shield
    }
}