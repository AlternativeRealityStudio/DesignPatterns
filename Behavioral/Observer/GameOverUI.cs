using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameOverUI : MonoBehaviour, IHealthObserver
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private GameObject gameOverPanel;

    private void Start()
    {
        if (playerHealth != null)
        {
            playerHealth.RegisterObserver(this);
            gameOverPanel.SetActive(false);
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
        if (currentHealth <= 0)
        {
            gameOverPanel.SetActive(true);
        }
        else
        {
            gameOverPanel.SetActive(false);
        }
    }
}
