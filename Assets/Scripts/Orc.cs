using UnityEngine;

public class Orc : Monster
{
    public override int LootGold => 10;

    public void InitializeOrc(string name)
    {
        base.Init(name, 60, 12);
    }

    public override void Roar()
    {
        Debug.Log("Orc Roar!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} Punch, Deal {AttackPower} damage.");
    }
}
