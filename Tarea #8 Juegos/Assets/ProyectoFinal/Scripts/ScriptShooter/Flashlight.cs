using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (GetComponent<Light>().enabled == true)
            {
                GetComponent<Light>().enabled = false;
            }
            else
            {
                GetComponent<Light>().enabled = true;
            }
        }
    }
}
