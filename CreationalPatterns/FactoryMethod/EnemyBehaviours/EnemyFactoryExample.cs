using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactoryExample : MonoBehaviour
{
    private EnemyFactory enemyFactory;
    private List<Enemy> enemies;

    private void Start()
    {
        enemyFactory = new EnemyFactory();
        enemies = new List<Enemy>();

        enemies.Add(enemyFactory.CreateEnemy("Slow"));
        enemies.Add(enemyFactory.CreateEnemy("Fast"));
        enemies.Add(enemyFactory.CreateEnemy("Flying"));

        foreach (Enemy enemy in enemies)
        {
            enemy.Attack();
        }
    }
}
