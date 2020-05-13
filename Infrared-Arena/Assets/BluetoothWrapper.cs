using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluetoothWrapper : MonoBehaviour
{

    AndroidJavaClass cls_UnityPlayer;
    AndroidJavaObject obj_Activity;

    public void ConnectBlaster()
    {
        cls_UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        obj_Activity = cls_UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        obj_Activity.Call("connectWeapon");
    }

    void update()
    {

    }
}
