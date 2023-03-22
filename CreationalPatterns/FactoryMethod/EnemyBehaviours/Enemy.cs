using UnityEngine;

public class Enemy
{
    public string Name;
    public int Health;
    public float Speed;

    public virtual void Attack()
    {
        Debug.Log(Name + " attacked the player.");
    }
}
