using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string WeaponName { get; private set; }
    public int BonusDamage { get; private set; }
    public void InitWeapon(string nameWeapon, int damageValue)
    {
        WeaponName = nameWeapon;
        BonusDamage = damageValue;
    }
}
