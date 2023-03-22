using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public float HealthRestoreAmount { get; private set; }

    public HealthPowerUp(float healthRestoreAmount, string name, Sprite icon) : base(name, icon)
    {
        HealthRestoreAmount = healthRestoreAmount;
    }

    public override void ActivatePowerUp(FactoryPlayer player)
    {
        player.RestoreHealth(HealthRestoreAmount);
    }
}
