using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChain : MonoBehaviour
{
    private WeakEnemy _weakEnemy;
    private MediumEnemy _mediumEnemy;
    private StrongEnemy _strongEnemy;

    private void Start()
    {
        _weakEnemy = gameObject.AddComponent<WeakEnemy>();
        _mediumEnemy = gameObject.AddComponent<MediumEnemy>();
        _strongEnemy = gameObject.AddComponent<StrongEnemy>();
        _weakEnemy.Resistance = 0.2f;
        _mediumEnemy.Resistance = 0.5f;
        _strongEnemy.Resistance = 0.8f;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            CalculateDamage(10f);
        }
    }
    public void CalculateDamage(float damage)
    {
        _weakEnemy.TakeDamage(damage);
        _mediumEnemy.TakeDamage(damage);
        _strongEnemy.TakeDamage(damage);
    }
}
