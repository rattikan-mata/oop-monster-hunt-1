using UnityEngine;

public class Monster : Character
{
    private bool isDefeated;
    private int lootGold;
    public int LootGold { get => lootGold; set => lootGold = value; }

    public void Init(string newName, int newHealth, int gold, int attack)
    {
        base.Init(newName, newHealth, attack);
        isDefeated = false;
        LootGold = gold;
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
}
