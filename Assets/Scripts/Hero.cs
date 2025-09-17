using UnityEngine;

public class Hero : Character
{
    private int gold;

    public int Gold
    {
        get { return gold; }
        set
        {
            if (value < 0) gold = 0;
            else if (value > 999) gold = 999;
            else gold = value;
        }
    }

    public override void Init(string newName, int newHealth, int attack) 
    {
        base.Init(newName, newHealth, attack);
        Gold = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"{Name} Current Gold: {Gold}, IsAlive {IsAlive()}");
    }

    public void EarnGold(int lootGold)
    {
        Gold += lootGold;
        Debug.Log($"{Name} get {Gold} Gold");
    }
}
