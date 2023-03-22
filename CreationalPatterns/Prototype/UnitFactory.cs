using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnitFactory
{
    Unit CreateUnit(Unit prototype);
}

public class UnitFactory : MonoBehaviour, IUnitFactory
{
    public Unit CreateUnit(Unit prototype)
    {
        return prototype.Clone();
    }
}
