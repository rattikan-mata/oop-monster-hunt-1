using JetBrains.Annotations;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;
    private int health;
    private int attackPower;

    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (value <= 0) health = 0;
            else health = value;
        }
    }

    public int AttackPower { get => attackPower; set => attackPower = value; }

    public virtual void Init(string newName, int newHealth, int attack)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = attack;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{Name} Take {damage} Damage!, Current Health: {Health}");
    }

    public bool IsAlive()
    {
        return (Health > 0);
    }

    public virtual void ShowStat() 
    {
        Debug.Log($"Name: {Name} | Health: {Health} | Attack Power: {AttackPower}");
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(AttackPower);
    }
}
