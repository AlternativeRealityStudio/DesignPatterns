using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infantry : Unit
{
    public override Unit Clone()
    {
        GameObject clonedObject = Instantiate(this.gameObject);
        Infantry clonedInfantry = clonedObject.GetComponent<Infantry>();

        clonedInfantry.unitName = this.unitName;
        clonedInfantry.health = this.health;
        clonedInfantry.attackPower = this.attackPower;
        clonedInfantry.moveSpeed = this.moveSpeed;

        return clonedInfantry;
    }
    //for non-MonoBehaviour classes that don't require a deep copy
    public Unit CloneObject()
    {
        return (Infantry)this.MemberwiseClone();
    }
}
