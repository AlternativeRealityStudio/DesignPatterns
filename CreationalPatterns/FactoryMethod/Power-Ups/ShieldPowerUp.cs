using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : PowerUp
{
    public float ShieldDuration { get; private set; }

    public ShieldPowerUp(float shieldDuration, string name, Sprite icon) : base(name, icon)
    {
        ShieldDuration = shieldDuration;
    }

    public override void ActivatePowerUp(FactoryPlayer player)
    {
        player.ActivateShield(ShieldDuration);
    }
}