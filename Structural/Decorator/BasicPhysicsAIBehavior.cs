using UnityEngine;

public class BasicPhysicsAIBehavior : IPhysicsAIBehavior
{
    private Rigidbody _rigidbody;
    private Vector3 _direction;

    public BasicPhysicsAIBehavior(Rigidbody rigidbody, Vector3 direction)
    {
        _rigidbody = rigidbody;
        _direction = direction.normalized;
    }

    public void FixedUpdateBehavior()
    {
        _rigidbody.AddForce(_direction * Time.fixedDeltaTime, ForceMode.VelocityChange);
        Debug.Log("Basic ai behavior");
    }
}
