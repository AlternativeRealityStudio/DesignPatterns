using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Thief : VCharacter
{
    public override void Accept(ICharacterVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void ThrowFirebomb()
    {
        // Throw a firebomb weapon
    }
}