using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private BulletPool bulletPool;
    [SerializeField] private float fireRate = 0.5f;

    private float nextFireTime;

    private void Update()
    {
        if (Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        GameObject bullet = bulletPool.GetBullet();
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
    }
}
