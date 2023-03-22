using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCommand : IObserverCommand
{
    private Transform _transform;
    private Vector3 _previousPosition;
    private Vector3 _newPosition;

    public PositionCommand(Transform transform, Vector3 previousPosition, Vector3 newPosition)
    {
        _transform = transform;
        _previousPosition = previousPosition;
        _newPosition = newPosition;
    }

    public void Execute()
    {
        _transform.position = _newPosition;
    }

    public void Undo()
    {
        _transform.position = _previousPosition;
    }
}