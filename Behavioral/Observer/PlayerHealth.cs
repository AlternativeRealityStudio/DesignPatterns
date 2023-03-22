using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerHealth : MonoBehaviour
{
    //Delegates also could be suitable some cases
    [SerializeField] private int maxHealth = 100;
    private int currentHealth=100;

    private List<IHealthObserver> observers = new List<IHealthObserver>();

    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(10);
        }
    }
    public void RegisterObserver(IHealthObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IHealthObserver observer)
    {
        observers.Remove(observer);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        NotifyObservers();
    }
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }
    private void NotifyObservers()
    {
        foreach (IHealthObserver observer in observers)
        {
            observer.OnHealthChanged(currentHealth);
        }
    }
}
