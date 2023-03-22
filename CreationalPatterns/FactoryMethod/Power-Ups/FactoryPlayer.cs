using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPlayer : MonoBehaviour
{
    [SerializeField] private float Speed = 10f;
    [SerializeField] private GameObject Shield;
    [SerializeField] private float Health = 0f;
    public void SpeedBoost(float speedBoostAmount)
    {
        Speed += speedBoostAmount;
    }
    public void ActivateShield(float shieldDuration)
    {
        StartCoroutine(ShieldActiveTime(shieldDuration));
    }
    public void RestoreHealth(float healthRestoreAmount)
    {
        Health += healthRestoreAmount;
    }

    IEnumerator ShieldActiveTime(float duration)
    {
        Shield.SetActive(true);
        yield return new WaitForSeconds(duration);
        Shield.SetActive(false);
    }
}
