using UnityEngine;

// Concrete Product B
public class Axe : Weapon
{
    public override void Attack()
    {
        Debug.Log("Chopping with axe");
    }
}
