using UnityEngine;

public class HeavyWeapon : Weapon
{
    [SerializeField] private float heavyMultiplier = 2f;

    public override float GetDamage()
    {
        return baseDamage * heavyMultiplier;
    }
}