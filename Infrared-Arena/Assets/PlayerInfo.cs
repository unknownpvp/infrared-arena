using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public UnityEngine.UI.InputField nameField;
    public int health;
    public static string playerName;
    public string scene;
    void saveName()
    {
        nameField = gameObject.GetComponent<UnityEngine.UI.InputField>();
    }

    public void OnMouseDown()
    {
        playerName = nameField.text;
        PlayerPrefs.SetString("playername", playerName);
        SceneManager.LoadScene(scene);
    }
}
