using UnityEngine;

public class Goblin : Monster
{
    public override int LootGold => 5;

    public void InitializeGoblin(string name)
    {
        base.Init(name, 40, 8);
    }

    public override void Roar()
    {
        Debug.Log("Goblin Roar!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} Quick Stab, Deal {AttackPower} damage.");
    }
}
