using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPhysicsSystem
{
    void AddForce(Rigidbody2D rigidbody, Vector2 force);
    void AddTorque(Rigidbody2D rigidbody, float torque);
    // ... other physics methods ...
}

