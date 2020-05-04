using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinLobby : MonoBehaviour
{
	public UnityEngine.UI.InputField lobbyField;
	public UnityEngine.UI.InputField playerField;

	public static string playerName;
	public static string lobbyName;

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
