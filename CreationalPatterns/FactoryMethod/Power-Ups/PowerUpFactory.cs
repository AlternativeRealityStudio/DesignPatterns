using UnityEngine;

public class PowerUpFactory
{
    [SerializeField] private Sprite speedBoostIcon;
    [SerializeField] private Sprite healthRestoreIcon;
    [SerializeField] private Sprite shieldIcon;
    public PowerUpFactory()
    {
        speedBoostIcon = (Sprite)Resources.Load("FactoryMethod/Powerups.png",typeof(Sprite));//speedBoost
        healthRestoreIcon = (Sprite)Resources.Load("FactoryMethod/Powerups.png", typeof(Sprite));//healthRestore
        speedBoostIcon = (Sprite)Resources.Load("FactoryMethod/Powerups.png", typeof(Sprite));//speedBoost
    }
    public PowerUp CreatePowerUp(string powerUpType)
    {
        switch (powerUpType)
        {
            case "speedboost":
                return new SpeedBoostPowerUp(2.0f, "Speed Boost", speedBoostIcon);
            case "health":
                return new HealthPowerUp(20.0f, "Health Restore", healthRestoreIcon);
            case "shield":
                return new ShieldPowerUp(10.0f, "Shield Boost", shieldIcon);
            default:
                throw new System.ArgumentException("Invalid power-up type");
        }
    }
}
