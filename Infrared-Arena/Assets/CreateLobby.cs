using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateLobby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    string screen;
    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Player" + theName;
        SceneManager.LoadScene(screen);
    }

}
