using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakEnemy : CEnemy
{
    public override void TakeDamage(float damage)
    {
        float actualDamage = damage * (1 - Resistance);
        Health -= actualDamage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("Weak Enemy Damage->Health:" + Health);
    }
}
