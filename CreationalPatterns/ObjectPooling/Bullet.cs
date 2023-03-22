using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 2f;

    private BulletPool bulletPool;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Initialize(BulletPool pool)
    {
        bulletPool = pool;
    }

    private void OnEnable()
    {
        Invoke(nameof(ReturnToPool), lifeTime);
        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Handle collision logic, e.g., damage enemies
        ReturnToPool();
    }

    private void ReturnToPool()
    {
        CancelInvoke();
        rb.velocity = Vector3.zero;
        bulletPool.ReturnBullet(gameObject);
    }
}
