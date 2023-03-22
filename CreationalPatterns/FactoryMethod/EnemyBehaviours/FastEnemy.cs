using UnityEngine;

public class FastEnemy : Enemy
{
    public FastEnemy()
    {
        Name = "Fast Enemy";
        Health = 10;
        Speed = 5.0f;
    }

    public override void Attack()
    {
        Debug.Log(Name + " attacked the player quickly.");
    }
}
