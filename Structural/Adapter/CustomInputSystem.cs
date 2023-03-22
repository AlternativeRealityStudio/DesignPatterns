using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CustomInputSystem
{
    private Dictionary<string, KeyCode> _buttonMappings;
    private Dictionary<string, string> _axisMappings;

    public CustomInputSystem()
    {
        _buttonMappings = new Dictionary<string, KeyCode>
        {
            { "Jump", KeyCode.Space },
            // Add more button mappings as needed
        };

        _axisMappings = new Dictionary<string, string>
        {
            { "Horizontal", "Horizontal" },
            { "Vertical", "Vertical" },
            // Add more axis mappings as needed
        };
    }

    public float GetAxisValue(string axisName)
    {
        if (_axisMappings.TryGetValue(axisName, out string unityAxisName))
        {
            return Input.GetAxis(unityAxisName);
        }

        Debug.LogWarning($"CustomInputSystem: Axis '{axisName}' not found.");
        return 0f;
    }

    public bool IsButtonDown(string buttonName)
    {
        if (_buttonMappings.TryGetValue(buttonName, out KeyCode keyCode))
        {
            return Input.GetKeyDown(keyCode);
        }

        Debug.LogWarning($"CustomInputSystem: Button '{buttonName}' not found.");
        return false;
    }
}
