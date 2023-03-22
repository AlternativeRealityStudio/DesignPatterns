using UnityEngine;

public class SlowEnemy : Enemy
{
    public SlowEnemy()
    {
        Name = "Slow Enemy";
        Health = 20;
        Speed = 2.0f;
    }

    public override void Attack()
    {
        Debug.Log(Name + " attacked the player slowly.");
    }
}