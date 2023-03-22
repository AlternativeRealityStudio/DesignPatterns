using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysicsEngine : IPhysicsSystem
{
    public void AddForce(Rigidbody2D rigidbody, Vector2 force)
    {
        // Add force using the custom physics engine
    }

    public void AddTorque(Rigidbody2D rigidbody, float torque)
    {
        // Add torque using the custom physics engine
    }

    // ... other physics methods ...
}
