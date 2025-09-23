using UnityEngine;

public enum MonsterType
{
    Goblin,
    Orc,
    Dragon
}

public class Monster : Character
{
    private bool isDefeated;
    private int lootGold;
    public int LootGold { get => lootGold; set => lootGold = value; }

    public void Init(MonsterType monsterType)
    {
        switch (monsterType)
        {
            case MonsterType.Goblin:
                base.Init("Goblin", 50, 10);
                lootGold = 5;
                break;
            case MonsterType.Orc:
                base.Init("Orc", 100, 15);
                lootGold = 10;
                break;
            case MonsterType.Dragon:
                base.Init("Dragon", 150, 20);
                lootGold = 15;
                break;
            default:
                base.Init("Unknown", 50, 10);
                lootGold = 0;
                break;

        }

        isDefeated = false;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"{Name} Loot Gold: {lootGold}");
    }

    public int DropReward()
    {
        return LootGold;
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"Monster {Name} bite hero {target.Name}");
    }

    public override void Attack(Character target, int bonusAttack)
    {
        int damage = (AttackPower * 2) + (bonusAttack / 2);
        target.TakeDamage(damage);
        Debug.Log($"Monster {Name} bite(Crit!) hero {target.Name}");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}
