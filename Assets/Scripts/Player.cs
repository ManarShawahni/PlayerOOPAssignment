using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;

    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
        Debug.Log($"Player '{playerName}' has entered the game with {health} health.");
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"{playerName} received a healing of {amount} points. Current health: {health}");
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log($"{playerName} has been fully restored to full health: {health}");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log("Total Players: " + playerCount);
    }
}
