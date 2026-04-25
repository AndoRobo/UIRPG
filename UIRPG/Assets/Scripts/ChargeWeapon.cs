using UnityEngine;

public class ChargeWeapon : Weapon
{
   [SerializeField] private float chargeIncrement = 0.5f;
   private float charge = 0;
   public override float GetDamage()
   {

      float damage = baseDamage + charge;
      charge += chargeIncrement;
      return damage;
   }
}
