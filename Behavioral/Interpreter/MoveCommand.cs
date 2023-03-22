using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Vector3 targetPosition;

    public MoveCommand(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    public void Execute(GameObject gameObject)
    {
        gameObject.transform.position = targetPosition;
    }
}