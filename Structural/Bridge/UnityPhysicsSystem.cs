using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityPhysicsSystem : IPhysicsSystem
{
    public void AddForce(Rigidbody2D rigidbody, Vector2 force)
    {
        rigidbody.AddForce(force);
    }

    public void AddTorque(Rigidbody2D rigidbody, float torque)
    {
        rigidbody.AddTorque(torque);
    }

    // ... other physics methods ...
}

