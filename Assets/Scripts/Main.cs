using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hero hero = new Hero("HeroA", 75);
        Debug.Log($"Hero Name: {hero.name}, Health: {hero.health}, Gold: {hero.gold}");

        Monster monster1 = new Monster("Orc", 25);
        Debug.Log($"Monster Name: {monster1.name}, HP: {monster1.health}");

        Monster monster2 = new Monster("Goblin", 30);
        Debug.Log($"Monster Name: {monster2.name}, HP: {monster2.health}");

        Monster monster3 = new Monster("Dragon", 35);
        Debug.Log($"Monster Name: {monster3.name}, HP: {monster3.health}");
    }
}
