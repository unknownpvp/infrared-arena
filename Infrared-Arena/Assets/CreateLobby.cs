using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateLobby : MonoBehaviour
{
    public UnityEngine.UI.InputField lobbyField;
	public UnityEngine.UI.InputField playerField;

	public static string playerName;
	public static string lobbyName;
	public static string gameMode;
	public static string timeLimit;

	public static string timeLimitOutput;
	public static string gameModeOutput;

	public void HandleGameModeData(int val)
	{
		gameModeOutput = "Team";
		if(val == 0)
		{
			gameModeOutput = "Team";
		}
		if (val == 1)
		{
			gameModeOutput = "Free for All";
		}
		if (val == 2)
		{
			gameModeOutput = "Capture the Flag";
		}
		if (val == 3)
		{
			gameModeOutput = "Skirmish";
		}
	}

	public void HandleTimeLimitData(int val)
	{
		timeLimitOutput = "10 min";
		if (val == 0)
		{
			timeLimitOutput = "10 min";
		}
		if (val == 1)
		{
			timeLimitOutput = "20 min";
		}
		if (val == 2)
		{
			timeLimitOutput = "30 min";
		}
		if (val == 3)
		{
			timeLimitOutput = "1 hr";
		}
		if (val == 4)
		{
			timeLimitOutput = "2 hrs";
		}
		if (val == 5)
		{
			timeLimitOutput = "No limit";
		}
	}

	string inputLobby;
	public string scene;
    void saveLobby()
    {
        lobbyField = gameObject.GetComponent<UnityEngine.UI.InputField>();
		playerField = gameObject.GetComponent<UnityEngine.UI.InputField>();
    }

	public void OnMouseDown()
	{
		lobbyName = lobbyField.text;
		playerName = playerField.text;
		//PlayerPrefs.SetString("lobbyname", name);
		SceneManager.LoadScene(scene);
	}



}
