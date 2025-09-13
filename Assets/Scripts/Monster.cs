using UnityEngine;

public class Monster
{
    private string name;
    private int health;
    private int gold;
    private int lootReward;
    private bool defeated = false;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Monster"; }
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

    public int AttackPower { get; private set; }

    public int LootReward
    {
        get { return lootReward; }
        set
        {
            if (value < 0) { lootReward = 0; }
            else lootReward = value;
        }
    }

    public Monster(string newName, int newHp, int newAttackPower, int newLootReward)
    {
        name = newName;
        health = newHp;
        AttackPower = newAttackPower;
        LootReward = newLootReward;
    }

    public void ShowStat()
    {
        Debug.Log($"Monster name: {Name} | Monster health: {Health} | Attack Power: {AttackPower} | Loot Reward: {LootReward}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"Monater Takes {damageValue} Damage.");
    }

    public void Attack(Hero target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public int DropReward()
    {
        return LootReward;
    }
}
