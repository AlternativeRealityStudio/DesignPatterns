using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPowerUp : PowerUp
{
    public float SpeedBoostAmount { get; private set; }

    public SpeedBoostPowerUp(float speedBoostAmount, string name, Sprite icon) : base(name, icon)
    {
        SpeedBoostAmount = speedBoostAmount;
    }

    public override void ActivatePowerUp(FactoryPlayer player)
    {
        player.SpeedBoost(SpeedBoostAmount);
    }
}