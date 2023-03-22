using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeController : MonoBehaviour
{
    private CommandManager _commandManager;
    private Vector3 _previousScale;
    private Quaternion _previousRotation;
    private Vector3 _previousPosition;

    private void Start()
    {
        _commandManager = FindObjectOfType<CommandManager>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            _previousScale = transform.localScale;
            _previousRotation = transform.rotation;
            _previousPosition = transform.position;
            Debug.Log("current state");
        }

        if (Input.GetMouseButtonUp(0))
        {
            // Create ScaleCommand, RotationCommand, and PositionCommand objects for the current transform state
            ScaleCommand scaleCommand = new ScaleCommand(transform, _previousScale, transform.localScale);
            RotationCommand rotationCommand = new RotationCommand(transform, _previousRotation, transform.rotation);
            PositionCommand positionCommand = new PositionCommand(transform, _previousPosition, transform.position);

            // Execute the commands and add them to the command stack
            _commandManager.ExecuteCommand(scaleCommand);
            _commandManager.ExecuteCommand(rotationCommand);
            _commandManager.ExecuteCommand(positionCommand);
            Debug.Log("saved");
        }

        if (Input.GetMouseButtonDown(1))
        {
            // Undo the last command
            _commandManager.UndoCommand();
            Debug.Log("Reversing");
        }
    }
}