using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFactoryExample : MonoBehaviour
{
    private PowerUpFactory powerUpFactory;

    private void Start()
    {
        powerUpFactory = new PowerUpFactory();

        // Create a speed boost power-up
        PowerUp speedBoost = powerUpFactory.CreatePowerUp("speedboost");

        // Create a health restore power-up
        PowerUp healthRestore = powerUpFactory.CreatePowerUp("health");

        // Create a shield power-up
        PowerUp shieldBoost = powerUpFactory.CreatePowerUp("shield");

        // Activate the power-ups for the player
        FactoryPlayer player = FindObjectOfType<FactoryPlayer>();
        speedBoost.ActivatePowerUp(player);
        healthRestore.ActivatePowerUp(player);
        shieldBoost.ActivatePowerUp(player);
    }
}
