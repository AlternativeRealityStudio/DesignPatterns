using UnityEngine;

// Concrete Factory C
public class BowFactory : WeaponFactory
{
    private GameObject bowPrefab;
    private void Awake()
    {
        bowPrefab = (GameObject)Resources.Load("AbstractFactory/Bow", typeof(GameObject));
    }
    public override Weapon CreateWeapon()
    {
        GameObject weapon = Instantiate(bowPrefab, Vector3.zero, Quaternion.identity);
        return weapon.GetComponent<Bow>();
    }
}
