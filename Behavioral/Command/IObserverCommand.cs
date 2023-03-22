using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserverCommand
{
    void Execute();
    void Undo();
}
