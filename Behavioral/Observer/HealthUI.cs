using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour, IHealthObserver
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Text healthText;

    private void Start()
    {
        if (playerHealth != null)
        {
            playerHealth.RegisterObserver(this);
            OnHealthChanged(playerHealth.GetCurrentHealth()); // Update UI on start
        }
    }

    private void OnDestroy()
    {
        if (playerHealth != null)
        {
            playerHealth.UnregisterObserver(this);
        }
    }

    public void OnHealthChanged(int currentHealth)
    {
        healthText.text = "Health: " + currentHealth;
    }
}
