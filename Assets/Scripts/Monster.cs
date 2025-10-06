using UnityEngine;

public abstract class Monster : Character
{
    private bool isDefeated;
    public abstract int LootGold { get; }

    public abstract void Roar();

    public int DropReward()
    {
        return LootGold;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"{Name} Loot Gold: {LootGold}");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
    }

    public override void Attack(Character target, int bonusAttack)
    {
        int damage = (AttackPower * 2) + (bonusAttack / 2);
        target.TakeDamage(damage);
        Debug.Log($"Monster {Name} bite(Crit!) hero {target.Name}, Deal: {damage}");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}
