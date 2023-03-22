using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInputHandler : IInputHandler
{
    // Assuming CustomInputSystem is a class from the custom input library
    private CustomInputSystem _inputSystem;

    public CustomInputHandler(CustomInputSystem inputSystem)
    {
        _inputSystem = inputSystem;
    }

    public float GetAxis(string axisName)
    {
        // Assume GetAxisValue is a method in the custom input library
        return _inputSystem.GetAxisValue(axisName);
    }

    public bool GetButtonDown(string buttonName)
    {
        // Assume IsButtonDown is a method in the custom input library
        return _inputSystem.IsButtonDown(buttonName);
    }
}
