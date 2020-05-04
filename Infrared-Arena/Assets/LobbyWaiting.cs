using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyWaiting : MonoBehaviour
{
    // Start is called before the first frame update
    //public string user;
    public GameObject lobbyDisplay;
    public GameObject playerDisplay;
    public GameObject gameModeDisplay;
    public GameObject timeLimitDisplay;

    public void Start() 
    {
        lobbyDisplay.GetComponent<Text>().text = CreateLobby.lobbyName;
        playerDisplay.GetComponent<Text>().text = CreateLobby.playerName;
        gameModeDisplay.GetComponent<Text>().text = "Game Mode: "+ CreateLobby.gameModeOutput;
        timeLimitDisplay.GetComponent<Text>().text = "Time Limit: "+CreateLobby.timeLimitOutput;
    }
        
    
}
