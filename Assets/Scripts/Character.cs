using JetBrains.Annotations;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;
    protected int maxHealth = 100;
    private int attackPower;

    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "Unknown" : value;
    }

    public int Health { get; protected set; }

    public int AttackPower { get => attackPower; set => attackPower = value; }

    public void Init(string newName, int newHealth, int attack)
    {
        Name = newName;
        Health = newHealth;
        AttackPower = attack;
    }

    public void TakeDamage(int damage)
    {
        Health = Mathf.Clamp(Health - damage, 0, maxHealth);
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

    public abstract void Attack(Character target);
    public abstract void Attack(Character target, int bonusAttack);
    public abstract void OnDefeated();
}
