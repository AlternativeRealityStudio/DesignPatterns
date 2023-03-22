using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsSystemBridge
{
    private IPhysicsSystem physicsSystem;

    public PhysicsSystemBridge(IPhysicsSystem physicsSystem)
    {
        this.physicsSystem = physicsSystem;
    }

    public void AddForce(Rigidbody2D rigidbody, Vector2 force)
    {
        physicsSystem.AddForce(rigidbody, force);
    }

    public void AddTorque(Rigidbody2D rigidbody, float torque)
    {
        physicsSystem.AddTorque(rigidbody, torque);
    }

    // ... other physics methods ...
}
