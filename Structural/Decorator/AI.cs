using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private IPhysicsAIBehavior _behavior;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _behavior = new BasicPhysicsAIBehavior(_rigidbody, Vector3.forward);
        _behavior = new FollowPlayerPhysicsAIBehavior(_rigidbody, _behavior, GameObject.Find("Player").transform);
       // _behavior = new RandomizeDirectionPhysicsAIBehavior(_rigidbody, _behavior, 5f);
    }

    private void FixedUpdate()
    {
        _behavior.FixedUpdateBehavior();
    }
}
