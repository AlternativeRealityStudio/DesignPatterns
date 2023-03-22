using UnityEngine;

// Concrete Product C
public class Bow : Weapon
{
    public override void Attack()
    {
        Debug.Log("Shooting arrow with bow");
    }
}

