using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int health = 500;
    public string username = "Linda";
    // Start is called before the first frame update

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        health = data.health;
        username = data.username;
    }
    #region
    public void ChangeHealth(int amount)
    {
        health += amount;
    }
    #endregion
}
