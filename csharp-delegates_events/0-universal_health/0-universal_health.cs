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
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;

        this.hp = this.maxHp;
    }

    /// <summary> Prints the player's current health to the console. </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
