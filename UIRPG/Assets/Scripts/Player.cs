using UnityEngine;

public class Player : Character
{

    [SerializeField] private Weapon selectedWeapon;
    public override void Attack(Character toHit)
    {
        //float damage = selectedWeapon.GetDamage();
        //toHit.GetHit(damage);
        toHit.GetHit(selectedWeapon);
      Debug.Log("Player attacking enemy");
    }
}
