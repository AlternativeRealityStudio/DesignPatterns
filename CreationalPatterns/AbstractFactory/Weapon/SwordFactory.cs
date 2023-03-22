using UnityEngine;

// Concrete Factory A
public class SwordFactory : WeaponFactory
{
    private GameObject swordPrefab;
    private void Awake()
    {
        swordPrefab = (GameObject)Resources.Load("AbstractFactory/Sword",typeof(GameObject));
    }
    public override Weapon CreateWeapon()
    {
        GameObject weapon = Instantiate(swordPrefab, Vector3.zero, Quaternion.identity);
        return weapon.GetComponent<Sword>();
    }
}
