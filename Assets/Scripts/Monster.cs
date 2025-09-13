class Monster
{
    public string name;
    public int health;
    private bool defeated;

    public Monster(string newName, int newHealth)
    {
        name = newName;
        health = newHealth;
        defeated = false;
    }
}
