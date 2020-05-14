using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    //public GameObject helpMenuUI;

    //public static bool aboutOpen = false;
    //public GameObject aboutUI;
    //private string openedObject;
    public GameObject exitMenuUI;
    public static bool exitOpen = false;
    private string openedObject;

    private void Update()
    {
            if (exitOpen) {
                exitMenuUI.SetActive(true);
                exitOpen = true;
            }
            else
            {
                exitMenuUI.SetActive(false);
                exitOpen = false;
            }
    }
    public void OnMouseDown(string openBox)
    {
        openedObject = openBox;
        if (openBox == "exit")
        {
            exitOpen = true;
        }
    }

    public void Close()
    {
        if (openedObject == "exit")
        {
            exitMenuUI.SetActive(false);
            exitOpen = false;
        }
    }
}
