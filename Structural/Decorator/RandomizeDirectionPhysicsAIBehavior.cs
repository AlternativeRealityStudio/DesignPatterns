using UnityEngine;

public class RandomizeDirectionPhysicsAIBehavior : IPhysicsAIBehavior
{
    private Rigidbody _rigidbody;
    private IPhysicsAIBehavior _baseBehavior;
    private float _timeSinceDirectionChange;
    private float _timeBetweenDirectionChanges;

    public RandomizeDirectionPhysicsAIBehavior(Rigidbody rigidbody, IPhysicsAIBehavior baseBehavior, float timeBetweenDirectionChanges)
    {
        _rigidbody = rigidbody;
        _baseBehavior = baseBehavior;
        _timeSinceDirectionChange = 0f;
        _timeBetweenDirectionChanges = timeBetweenDirectionChanges;
    }

    public void FixedUpdateBehavior()
    {
        _timeSinceDirectionChange += Time.fixedDeltaTime;
        if (_timeSinceDirectionChange >= _timeBetweenDirectionChanges)
        {
            _timeSinceDirectionChange = 0f;
            _baseBehavior = new BasicPhysicsAIBehavior(_rigidbody, Random.insideUnitSphere);
        }
        _baseBehavior.FixedUpdateBehavior();
    }
}
