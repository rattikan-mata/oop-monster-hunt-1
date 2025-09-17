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

        currentMonster = Instantiate(monsterPrefabs[0]);
        currentMonster.Init("Goblin", 50, 10, 5);
        monsters.Add(currentMonster);
        currentMonster.ShowStat();

        currentMonster = Instantiate(monsterPrefabs[1]);
        currentMonster.Init("Orc", 100, 15, 10);
        monsters.Add(currentMonster);
        currentMonster.ShowStat();

        currentMonster = Instantiate(monsterPrefabs[2]);
        currentMonster.Init("Dragon", 150, 20, 15);
        monsters.Add(currentMonster);
        currentMonster.ShowStat();
    }
}
