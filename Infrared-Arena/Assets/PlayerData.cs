using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    // Start is called before the first frame update
    public string username;
    public int health;

    public PlayerData(PlayerInfo player)
    {
        health = player.health;
        username = player.username;
    }
}
