using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon selectedWeapon;

    [SerializeField] private Weapon basicWeapon;
    [SerializeField] private Weapon chargeWeapon;
    [SerializeField] private Weapon heavyWeapon;

    public Weapon SelectedWeapon
    {
        get { return selectedWeapon; }
        set { selectedWeapon = value; }
    }

    public void SelectBasicWeapon()
    {
        selectedWeapon = basicWeapon;

        Debug.Log("Selected Basic Weapon");
    }

    public void SelectChargeWeapon()
    {
        selectedWeapon = chargeWeapon;

        Debug.Log("Selected Charge Weapon");
    }

    public void SelectHeavyWeapon()
    {
        selectedWeapon = heavyWeapon;

        Debug.Log("Selected Heavy Weapon");
    }

    public override string Attack(Character toHit)
    {
        float damage = selectedWeapon.GetDamage();

        toHit.GetHit(damage);

        return CharName + " attacked "
                        + toHit.CharName
                        + " with "
                        + selectedWeapon.name
                        + " for "
                        + damage.ToString("F1")
                        + " damage!";
    }
}