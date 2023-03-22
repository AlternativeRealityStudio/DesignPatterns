using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCommand : IObserverCommand
{
    private Transform _transform;
    private Quaternion _previousRotation;
    private Quaternion _newRotation;

    public RotationCommand(Transform transform, Quaternion previousRotation, Quaternion newRotation)
    {
        _transform = transform;
        _previousRotation = previousRotation;
        _newRotation = newRotation;
    }

    public void Execute()
    {
        _transform.rotation = _newRotation;
    }

    public void Undo()
    {
        _transform.rotation = _previousRotation;
    }
}
