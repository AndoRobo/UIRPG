using UnityEngine;

public class Enemy : Character
{

   [SerializeField] private float minDamage, maxDamage;
   [SerializeField] private Sprite enemyImage;

   public Sprite EnemyImage
   {
      get { return enemyImage; }
   }

   public override string Attack(Character toHit)
   {
      float damage = Random.Range(minDamage, maxDamage);

      toHit.GetHit(damage);

      return CharName + " attacked "
                      + toHit.CharName
                      + " for "
                      + damage.ToString("F1")
                      + " damage!";
   }
}
