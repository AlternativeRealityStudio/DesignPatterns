using UnityEngine;
public class FlyingEnemy : Enemy
{
    public FlyingEnemy()
    { 
        Name = "Flying Enemy";
        Health = 5;
        Speed = 3.0f;
    }

    public override void Attack()
    {
        Debug.Log(Name + " swooped down and attacked the player.");
    }
}