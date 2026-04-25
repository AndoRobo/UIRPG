using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public string charName;
    public float health;

    public abstract void Attack();
}
