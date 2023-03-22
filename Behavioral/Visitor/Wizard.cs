using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : VCharacter
{
    public override void Accept(ICharacterVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void CastFireball()
    {
        // Cast a fireball spell
    }

    public void Shield()
    {
        // Cast a shield spell
    }
}
