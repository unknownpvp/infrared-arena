using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, player.transform.position, speed);
        //transform.position = smoothedPosition;
        transform.position = new Vector3( player.transform.position.x, this.transform.position.y, this.transform.position.z );
    }
}
