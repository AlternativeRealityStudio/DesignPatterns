using UnityEngine;

// Concrete Factory B
public class AxeFactory : WeaponFactory
{
    private GameObject axePrefab;
    private void Awake()
    {
        axePrefab = (GameObject)Resources.Load("AbstractFactory/Axe", typeof(GameObject));
    }
    public override Weapon CreateWeapon()
    {
        GameObject weapon = Instantiate(axePrefab, Vector3.zero, Quaternion.identity);
        return weapon.GetComponent<Axe>();
    }
}
