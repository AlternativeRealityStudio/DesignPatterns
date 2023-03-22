using UnityEngine;
public class EnemyFactory
{
    public Enemy CreateEnemy(string type)
    {
        switch (type)
        {
            case "Slow":
                return new SlowEnemy();
            case "Fast":
                return new FastEnemy();
            case "Flying":
                return new FlyingEnemy();
            default:
                Debug.Log("Invalid enemy type.");
                return null;
        }
    }
}