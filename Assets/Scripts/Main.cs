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

        currentMonster = Instatiate(monsterPrefabs[0]);
        currentMonster.Init("Goblin", 50, 10, 5);
        Monster.Add(currentMonster);
        currentMonster.ShowStat();

        currentMonster = Instatiate(monsterPrefabs[1]);
        currentMonster.Init("Orc", 100, 15, 10);
        Monster.Add(currentMonster);
        currentMonster.ShowStat();

        currentMonster = Instatiate(monsterPrefabs[2]);
        currentMonster.Init("Dragon", 150, 20, 15);
        Monster.Add(currentMonster);
        currentMonster.ShowStat();
    }
}
