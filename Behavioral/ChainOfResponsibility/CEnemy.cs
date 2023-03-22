using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CEnemy : MonoBehaviour
{
    public float Health=100f;
    public float Resistance;

    public abstract void TakeDamage(float damage);
}
