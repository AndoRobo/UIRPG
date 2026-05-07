using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
   [SerializeField] protected float baseDamage;

   public virtual void ShowWeapon()
   {
      Debug.Log("Weapon equipped");
   }
   public abstract float GetDamage();
}
