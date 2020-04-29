using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchSpawn : MonoBehaviour
{
    public GameObject Regroup;
    public GameObject Enemy;
    public GameObject Backup;
    public GameObject Thankyou;
    Dropdown dropdown;

    private Vector3 tpos;

    // Start is called before the first frame update
    void Start()
    {
        // variable for the dropdown menu
        dropdown = GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((dropdown.value != 0) && (Input.touchCount < 0))
        {
            Touch touch = Input.GetTouch(0);
            tpos = Camera.main.ScreenToWorldPoint(touch.position);
            tpos.Set(tpos.x, tpos.y, -5);


            // change ping according to index chosen on dropdown
            if (dropdown.value == 1)
            {
                GameObject newPing = (GameObject)Instantiate(Regroup, tpos, Quaternion.identity);
                Destroy(newPing, 5);
                dropdown.value = 0;
            }
            else if (dropdown.value == 2)
            {
                GameObject newPing = (GameObject)Instantiate(Enemy, tpos, Quaternion.identity);
                Destroy(newPing, 5);
                dropdown.value = 0;
            }
            else if (dropdown.value == 3)
            {
                GameObject newPing = (GameObject)Instantiate(Backup, tpos, Quaternion.identity);
                Destroy(newPing, 5);
                dropdown.value = 0;
            }
            else if (dropdown.value == 4)
            {
                GameObject newPing = (GameObject)Instantiate(Thankyou, tpos, Quaternion.identity);
                Destroy(newPing, 10);
                dropdown.value = 0;
            }
        }




        /*
        //--------------------------------------------------------------------------------------
        // stores mouse click coordinates
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);

        if (Input.GetMouseButtonDown(0))
        {

            // retrives coordinates from mouse button click
            Vector3 worldPos;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000f))
            {
                worldPos = hit.point;
                worldPos.Set(worldPos.x, worldPos.y, -5);
            }
            else
            {
                worldPos = Camera.main.ScreenToWorldPoint(mousePos);
                worldPos.Set(worldPos.x, worldPos.y, -5);
            }

            // change ping according to index chosen on dropdown
            if (dropdown.value == 1)
            {
                GameObject newPing = (GameObject)Instantiate(Regroup, worldPos, Quaternion.identity);
                Destroy(newPing, 5);
                dropdown.value = 0;
            }
            else if (dropdown.value == 2)
            {
                GameObject newPing = (GameObject)Instantiate(Enemy, worldPos, Quaternion.identity);
                Destroy(newPing, 5);
                dropdown.value = 0;
            }
            else if (dropdown.value == 3)
            {
                GameObject newPing = (GameObject)Instantiate(Backup, worldPos, Quaternion.identity);
                Destroy(newPing, 5);
                dropdown.value = 0;
            }
            else if (dropdown.value == 4)
            {
                GameObject newPing = (GameObject)Instantiate(Thankyou, worldPos, Quaternion.identity);
                Destroy(newPing, 10);
                dropdown.value = 0;
            }
        }
        */

    }
}
