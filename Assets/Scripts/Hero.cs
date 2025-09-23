using UnityEngine;

public class Hero : Character
{
    public int Gold { get; private set; }

    public void Init(string newName, int newHealth, int attack)
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
        Gold = Mathf.Clamp(Gold + lootGold, 0, 999);
        Debug.Log($"{Name} get {Gold} Gold, Current Gold {Gold}");
    }

    public void Heal(int amount)
    {
        Health = Mathf.Clamp(Health + amount, 0, maxHealth);
        Debug.Log($"Hero {Name} Heal: {amount} HP");
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        Debug.Log($"Hero {Name} using sword attack {target.Name}");
    }

    public override void Attack(Character target, int bonusAttack)
    {
        int damage = AttackPower + bonusAttack;
        target.TakeDamage(damage);
        Debug.Log($"Hero {Name} using attack(Crit!) {target.Name}, Deal: {damage} damage");
    }

    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}
