using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Hero hero1;
    public List<Monster> monsterPrefabs;
    public List<Monster> monsters = new List<Monster>();
    public Monster currentMonster;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hero1.Init("Yasuo", 50, 10);
        hero1.ShowStat();

        SpawnMonster(MonsterType.Goblin);
        SpawnMonster(MonsterType.Orc);
        SpawnMonster(MonsterType.Dragon);

        currentMonster = monsters[0];

        Debug.Log("\n--- Battle ---");
        hero1.Attack(currentMonster);
        currentMonster = monsters[0];
        hero1.ShowStat();
        currentMonster.ShowStat();
        currentMonster.Attack(hero1);
        hero1.Attack(currentMonster, 15);
        hero1.Heal(25);
        hero1.EarnGold(currentMonster.LootGold);
        hero1.ShowStat();
    }

    public void SpawnMonster(MonsterType monsterType)
    {
        Monster monsterPrefab = monsterPrefabs[(int)monsterType];
        Monster monsterObject = Instantiate(monsterPrefab);
        monsterObject.Init(monsterType);
        monsters.Add(monsterObject);
    }
}
