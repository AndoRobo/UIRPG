using UnityEngine;

public class ChargeWeapon : Weapon
{
   [SerializeField] private float chargeIncrement = 0.5f;
   private float currentCharge = 0;
   public override float GetDamage()
   {

      float damage = baseDamage + currentCharge;
      currentCharge += chargeIncrement;
      return damage;
   }
}
