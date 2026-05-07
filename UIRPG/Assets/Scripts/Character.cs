using System;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private string charName;
    [SerializeField] private float maxHealth = 20f;

    private float health;
    public string CharName
    {
        get { return charName; }
    }
    //[SerializeField] private float health;

    public float Health

    {
        get { return health; }
        set { health = Mathf.Max(0, value); }
    }
    
    public abstract void Attack(Character toHit);

    public void GetHit(float damage)
    {
        Health -= damage;
        Debug.Log(charName + " got hit by damage of: " +damage+ " Health after attack : " + health);
    }

    public void GetHit(Weapon weapon)
    {
        Health -= weapon.GetDamage();
        Debug.Log(charName + " got hit by damage of: " +weapon.name+ " Health after attack : " + Health);
    }
    
    public bool IsDead()
    {
        return health <= 0;
    }

    public void ResetHealth()
    {
        Health = maxHealth;
    }

    private void Start()
    {
        ResetHealth();
    }
}
