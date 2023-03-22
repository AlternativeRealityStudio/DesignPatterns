using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlayerController : MonoBehaviour
{
    private IState _currentState;
    
    private void Start()
    {
        _currentState = new IdleState(this);
        _currentState.OnEnter();
    }

    private void Update()
    {
        _currentState.HandleInput();
        _currentState.Update();
    }

    public void TransitionToState(IState state)
    {
        _currentState.OnExit();
        _currentState = state;
        _currentState.OnEnter();
    }

    public bool IsGrounded()
    {
        // Check if the player is grounded
        return true;
    }

    public void ApplyJumpForce()
    {
        // Apply upward force to the player to simulate jumping
    }
}
 
