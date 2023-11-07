﻿using System;

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
        {
            damage = 0;
            Console.WriteLine($"{name} takes 0 damage!");
        }
        ValidateHP(hp - damage);
    }

    /// <summary> Simulates a character healing damage based on the provided heal value. </summary>
    /// <param name="heal">The amount of healing applied to the character.</param>
    public void HealDamage(float heal)
    {
        if (heal > 0)
            Console.WriteLine($"{name} heals {heal} HP!");
        else
        {
            heal = 0;
            Console.WriteLine($"{name} heals 0 HP!");
        }
        ValidateHP(hp + heal);
    }

    /// <summary> Validates the new HP value and applies it to the character's health. </summary>
    /// <param name="newHp">The new HP value to be validated and applied to the character's health.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp > maxHp)
            hp = maxHp;
        else if (newHp < 0)
            hp = 0;
        else
            hp = newHp;
    }

    /// <summary> Applies the specified modifier to the given base value and returns the adjusted value. </summary>
    /// <param name="baseValue">The base value to which the modifier will be applied.</param>
    /// <param name="modifier">The modifier indicating how the base value should be adjusted.</param>
    /// <returns>The adjusted value based on the specified modifier.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return 0f;
        }
    }
}

/// <summary> Represents a set of predefined modifiers that can be applied to a base value. </summary>
public enum Modifier
{
    /// <summary> Represents a weak modifier </summary>
    Weak,
    /// <summary> Represents a base modifier </summary>
    Base,
    /// <summary> Represents a strong modifier </summary>
    Strong
}

/// <summary> Represents a delegate prototype for calculating modified values based on a base value and a specified modifier. </summary>
/// <param name="baseValue">The base value to be modified.</param>
/// <param name="modifier">The modifier to be applied to the base value.</param>
/// <returns>The modified value based on the applied modifier.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
