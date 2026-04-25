using UnityEngine;

public class Weapon : MonoBehaviour
{
   [SerializeField] internal float baseDamage;
   
   public virtual float GetDamage()
   {
      return baseDamage;
   }
}
