using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp
{
    public string Name { get; private set; }
    public Sprite Icon { get; private set; }

    public PowerUp(string name, Sprite icon)
    {
        Name = name;
        Icon = icon;
    }

    public abstract void ActivatePowerUp(FactoryPlayer player);
}
