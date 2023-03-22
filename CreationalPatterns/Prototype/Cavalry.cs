using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavalry : Unit
{
    public override Unit Clone()
    {
        GameObject clonedObject = Instantiate(this.gameObject);
        Cavalry clonedCavalry = clonedObject.GetComponent<Cavalry>();

        clonedCavalry.unitName = this.unitName;
        clonedCavalry.health = this.health;
        clonedCavalry.attackPower = this.attackPower;
        clonedCavalry.moveSpeed = this.moveSpeed;

        return clonedCavalry;
    }
}