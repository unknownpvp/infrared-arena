﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
	public static string playernamestr;
	public Text playername;
    // Start is called before the first frame update
    void Start()
    {
        playername.text = playernamestr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
