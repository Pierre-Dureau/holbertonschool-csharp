using System;

/// <summary> Represents a player entity in the game. </summary>

public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary> Initializes a new instance of the Player class with a default name "Player" and maximum health of 100. </summary>
    /// <param name="name">The name of the player (default is "Player").</param>
    /// <param name="maxHp">The maximum health points of the player (default is 100).</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;

        this.hp = this.maxHp;
    }

    /// <summary> Prints the player's current health to the console. </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary> Represents a delegate prototype for modifying health and contains methods for taking and healing damage. </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary> Simulates a character taking damage based on the provided damage value. </summary>
    /// <param name="damage">The amount of damage taken by the character.</param>
    public void TakeDamage(float damage)
    {
        if (damage > 0)
            Console.WriteLine($"{name} takes {damage} damage!");
        else
            Console.WriteLine($"{name} takes 0 damage!");
    }

    /// <summary> Simulates a character healing damage based on the provided heal value. </summary>
    /// <param name="heal">The amount of healing applied to the character.</param>
    public void HealDamage(float heal)
    {
        if (heal > 0)
            Console.WriteLine($"{name} heals {heal} HP!");
        else
            Console.WriteLine($"{name} heals 0 HP!");
    }
}
