using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private List<Monster> monsters = new List<Monster>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hero hero = new Hero("The Knight", 20, 15);

        Monster monster1 = new Monster("Orc", 20, 5, 15);
        Monster monster2 = new Monster("Goblin", 15, 4, 10);
        Monster monster3 = new Monster("Dragon", 300, 30, 100);

        monsters.Add(monster1);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monster("Evil Wing", 20, 10, 30));

        hero.ShowStat();

        foreach (var m in monsters)
        {
            m.ShowStat();
        }

        monster2.ShowStat();
        hero.Attack(monster2);
        monster2.ShowStat();

        hero.ShowStat();
        monster3.Attack(hero);
        hero.ShowStat();
    }
}
