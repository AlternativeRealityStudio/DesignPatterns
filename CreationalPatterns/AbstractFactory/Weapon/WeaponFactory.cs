using UnityEngine;
// Abstract Factory
public abstract class WeaponFactory : MonoBehaviour
{
    public abstract Weapon CreateWeapon();
}
