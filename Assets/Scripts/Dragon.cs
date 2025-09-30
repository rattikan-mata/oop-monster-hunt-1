using UnityEngine;

public class Dragon : Monster
{
    public override int LootGold => 15;

    public void InitializeDragon(string name)
    {
        base.Init(name, 100, 20);
    }

    public override void Roar()
    {
        Debug.Log("Dragon Roar!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} Fire Breath, Deal {AttackPower} damage.");
    }
}
