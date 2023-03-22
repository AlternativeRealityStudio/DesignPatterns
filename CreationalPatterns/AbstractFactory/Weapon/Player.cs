using UnityEngine;

 
public class Player : MonoBehaviour
{
    [SerializeField]
    private WeaponFactory AxeFactoryWeapon, SwordFactoryWeapon, BowFactoryWeapon;
    private void Awake()
    {
        AxeFactoryWeapon = gameObject.AddComponent<AxeFactory>();
        SwordFactoryWeapon = gameObject.AddComponent<SwordFactory>();
        BowFactoryWeapon = gameObject.AddComponent<BowFactory>();
    }
    public void Attack()
    {
        Weapon weapon = AxeFactoryWeapon.CreateWeapon();
        weapon.Attack();

        weapon = SwordFactoryWeapon.CreateWeapon();
        weapon.Attack();

        weapon = BowFactoryWeapon.CreateWeapon();
        weapon.Attack();
    }
    private void Start()
    {
        Attack();
    }
}
