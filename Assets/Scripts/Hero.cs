using UnityEngine;

public class Hero
{
    private string name;
    private int health;
    private int gold;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Hero"; }
            else name = value;
        }
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) { health = value; }
            else health = 0;
        }
    }

    public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else gold = value;
        }
    }

    public int AttackPower { get; private set; }

    public Hero(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;
        Gold = 0;
    }

    public void ShowStat()
    {
        Debug.Log($"Hero name: {Name} | Hero health: {Health} | Hero gold: {Gold}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
    }   

    public void Attack(Monster target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
