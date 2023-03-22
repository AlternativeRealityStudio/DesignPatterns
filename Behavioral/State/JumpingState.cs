using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IState
{
    private readonly StatePlayerController _playerController;

    public JumpingState(StatePlayerController playerController)
    {
        _playerController = playerController;
    }

    public void HandleInput()
    {
        // We don't handle input in this state
    }

    public void Update()
    {
        Debug.Log("JumpingState Update");

        // Check if the player has landed and transition to the idle state
        if (_playerController.IsGrounded())
        {
            _playerController.TransitionToState(new IdleState(_playerController));
        }
    }

    public void OnEnter()
    {
        Debug.Log("JumpingState OnEnter");

        // Apply upward force to the player to simulate jumping
        _playerController.ApplyJumpForce();
    }

    public void OnExit()
    {
        Debug.Log("JumpingState OnExit");
    }
}