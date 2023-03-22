using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityInputHandler : IInputHandler
{
    public float GetAxis(string axisName)
    {
        return UnityEngine.Input.GetAxis(axisName);
    }

    public bool GetButtonDown(string buttonName)
    {
        return UnityEngine.Input.GetButtonDown(buttonName);
    }
}
