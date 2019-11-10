using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputField : MonoBehaviour
{
	public InputField inputText;
	string nickname;

	void Start(){
		nickname = PlayerPrefs.GetString("nickname");
		inputText.text = nickname;
	}

	public void SaveThis(){
		nickname = inputText;
		PlayerPrefs.SetString("nickname", nickname);
	}
}
