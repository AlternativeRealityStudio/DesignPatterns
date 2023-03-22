using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour, IHealthObserver
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Slider healthSlider;

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

    public void OnHealthChanged(int _currentHealth)
    {
        healthSlider.value = (float)_currentHealth / playerHealth.GetMaxHealth();
    }
}
