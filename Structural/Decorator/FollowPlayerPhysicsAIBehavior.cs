using UnityEngine;

public class FollowPlayerPhysicsAIBehavior : IPhysicsAIBehavior
{
    private Rigidbody _rigidbody;
    private IPhysicsAIBehavior _baseBehavior;
    private Transform _playerTransform;

    public FollowPlayerPhysicsAIBehavior(Rigidbody rigidbody, IPhysicsAIBehavior baseBehavior, Transform playerTransform)
    {
        _rigidbody = rigidbody;
        _baseBehavior = baseBehavior;
        _playerTransform = playerTransform;
    }

    public void FixedUpdateBehavior()
    {
        Vector3 directionToPlayer = (_playerTransform.position - _rigidbody.position).normalized;
        _rigidbody.rotation = Quaternion.LookRotation(directionToPlayer);
        _baseBehavior.FixedUpdateBehavior();
    }
}
