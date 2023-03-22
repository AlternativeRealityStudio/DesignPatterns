using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGame : MonoBehaviour
{
    private PhysicsSystemBridge physicsSystemBridge;
    private Vector2 force = new Vector2(3,5);
    private float torque = 10f;
    private void Start()
    {
        // Use the default Unity physics engine by default
        physicsSystemBridge = new PhysicsSystemBridge(new UnityPhysicsSystem());
    }

    private void Update()
    {
        // ...

        // Switch to the custom physics engine
        //physicsSystemBridge = new PhysicsSystemBridge(new MyPhysicsEngine());

        // ...
    }

    private void FixedUpdate()
    {
        // Call the physics methods through the Bridge class
        physicsSystemBridge.AddForce(GetComponent<Rigidbody2D>(), force);
        physicsSystemBridge.AddTorque(GetComponent<Rigidbody2D>(), torque);
        // ... other physics methods ...
    }
}
