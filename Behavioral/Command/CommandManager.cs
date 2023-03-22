using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    private Stack<IObserverCommand> _commandStack = new Stack<IObserverCommand>();

    public void ExecuteCommand(IObserverCommand command)
    {
        command.Execute();
        _commandStack.Push(command);
    }

    public void UndoCommand()
    {
        if (_commandStack.Count > 0)
        {
            IObserverCommand command = _commandStack.Pop();
            command.Undo();
        }
    }
}