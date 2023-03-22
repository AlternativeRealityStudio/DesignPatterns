using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterVisitor
{
    void Visit(Wizard wizard);
    void Visit(Knight knight);
    void Visit(Thief thief);
}
