using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputField : MonoBehaviour
{
	public UnityEngine.UI.InputField inputText;
	string nickname;

	void Start(){
		//nickname = gameObject.GetComponent<InputField>();//PlayerPrefs.GetString("nickname");
		//inputText.text = nickname;
		inputText = gameObject.GetComponent <UnityEngine.UI.InputField>();
	}

	public void SaveThis(){
		nickname = inputText.text;
		PlayerPrefs.SetString("nickname", nickname);
		Debug.Log("Player Name is: " + inputText.text);
    //	Settings.playername = inputText.text;
	}
}
