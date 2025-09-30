using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero1;
    public List<Monster> monsterPrefabs;
    public List<Monster> monsters = new List<Monster>();
    public List<Weapon> weaponPrefabs;
    public Monster currentMonster;

    void Start()
    {
        hero1.Init("Yasuo", 50, 10);
        hero1.ShowStat();

        Weapon sword = Instantiate(weaponPrefabs[0], new Vector3(-3, -1, 0), Quaternion.identity);
        Weapon club = Instantiate(weaponPrefabs[0], new Vector3(-1, -1, 0), Quaternion.identity);

        sword.InitWeapon("Sword", 10);
        club.InitWeapon("Club", 20);

        Monster goblinObj = Instantiate(monsterPrefabs[0]);
        Goblin goblinMonster = goblinObj.GetComponent<Goblin>();
        if (goblinMonster != null)
        {
            goblinMonster.InitializeGoblin("Little Goblin");
        }
        monsters.Add(goblinMonster);

        Monster orcObj = Instantiate(monsterPrefabs[1]);
        Orc orcMonster = orcObj.GetComponent<Orc>();
        if (orcMonster != null)
        {
            orcMonster.InitializeOrc("Medium Orc");
        }
        monsters.Add(orcMonster);

        Monster dragonObj = Instantiate(monsterPrefabs[2]);
        Dragon dragonMonster = dragonObj.GetComponent<Dragon>();
        if (dragonMonster != null)
        {
            dragonMonster.InitializeDragon("Huge Dragon");
        }
        monsters.Add(dragonMonster);

        hero1.EquipWeapon(sword);
        monsters[1].EquipWeapon(club);

        hero1.Attack(monsters[1], hero1.EquippedWeapon);
        monsters[1].Attack(hero1, monsters[1].EquippedWeapon);

        foreach (Monster m in monsters)
        {
            m.ShowStat();
            m.Roar();
            m.Attack(hero1);
        }

        Debug.Log("\n--- Battle ---");
       /* hero1.Attack(currentMonster);
        currentMonster = monsters[0];
        hero1.ShowStat();
        currentMonster.ShowStat();
        currentMonster.Attack(hero1);
        hero1.Attack(currentMonster, 10);
        hero1.Heal(25);
        hero1.EarnGold(currentMonster.LootGold);
        hero1.ShowStat();*/
    }
}
