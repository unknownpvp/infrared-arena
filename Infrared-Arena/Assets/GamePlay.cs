using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    public GameObject playerName;
    // Update is called once per frame
    void Update()
    {
        playerName.GetComponent<Text>().text = PlayerInfo.playerName;
    }
}
