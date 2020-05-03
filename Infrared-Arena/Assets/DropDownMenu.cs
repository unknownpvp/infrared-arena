using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Drop Down Objects

public class DropDownMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public Transform gameLimitDropdown;
    public Transform timeLimitDropdown;
// ON MATCH SETTINGS SCREEN
    public void GetTimeLimit(int index)
    {   
				 //find the selected index
        int timeIndex = timeLimitDropdown.GetComponent<Dropdown> ().value;
 
                //find all options available within the dropdown menu
        List<Dropdown.OptionData> timeOptions = timeLimitDropdown.GetComponent<Dropdown>().options;
 
                //get the string value of the selected index
        string timeLimit = timeOptions[timeIndex].text;
    }

    public void GetGameMode(int index)
    {
                //find the selected index
        int gameIndex = gameLimitDropdown.GetComponent<Dropdown> ().value;
 
                //find all options available within the dropdown menu
        List<Dropdown.OptionData> gameOptions = gameLimitDropdown.GetComponent<Dropdown>().options;
 
                //get the string value of the selected index
        string gameMode = gameOptions[gameIndex].text;
    }

    

}
