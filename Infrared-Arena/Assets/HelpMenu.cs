using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public static bool menuOpen = false;

    public GameObject helpMenuUI;

    public static bool aboutOpen = false;
    public GameObject aboutUI;
    private string openedObject;

    //private void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        if (menuOpen)
    //        {
    //            ResumeHelp();
    //        }
    //        else
    //        {
    //            PauseHelp();
    //        }
    //    }
    //    if ()
    //    {

    //    }
    //}
    private void Update()
    {
            if (aboutOpen)
            {
                aboutUI.SetActive(true);
                aboutOpen = true;
            }
            else
            {
                aboutUI.SetActive(false);
                aboutOpen = false;
            }

            if (menuOpen) {
                helpMenuUI.SetActive(true);
                menuOpen = true;
            }
            else
            {
                helpMenuUI.SetActive(false);
                menuOpen = false;
            }
    }
    public void OnMouseDown(string openBox)
    {
        openedObject = openBox;
        if (openBox == "about")
        {
            aboutOpen = true;
        }
        else if (openBox == "help")
        {
            menuOpen = true;
        }
    }

    public void Close()
    {
        if (openedObject == "about")
        {
            aboutUI.SetActive(false);
            aboutOpen = false;
        }
        else if (openedObject == "help")
        {
            helpMenuUI.SetActive(false);
            menuOpen = false;
        }
    }
}
