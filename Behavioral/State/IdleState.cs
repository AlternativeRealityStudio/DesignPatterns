using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private readonly StatePlayerController _playerController;

    public IdleState(StatePlayerController playerController)
    {
        _playerController = playerController;
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerController.TransitionToState(new JumpingState(_playerController));
        }
    }

    public void Update()
    {
        Debug.Log("IdleState Update");
    }

    public void OnEnter()
    {
        Debug.Log("IdleState OnEnter");
    }

    public void OnExit()
    {
        Debug.Log("IdleState OnExit");
    }
}