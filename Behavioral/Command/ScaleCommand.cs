using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCommand : IObserverCommand
{
    private Transform _transform;
    private Vector3 _previousScale;
    private Vector3 _newScale;

    public ScaleCommand(Transform transform, Vector3 previousScale, Vector3 newScale)
    {
        _transform = transform;
        _previousScale = previousScale;
        _newScale = newScale;
    }

    public void Execute()
    {
        _transform.localScale = _newScale;
    }

    public void Undo()
    {
        _transform.localScale = _previousScale;
    }
}