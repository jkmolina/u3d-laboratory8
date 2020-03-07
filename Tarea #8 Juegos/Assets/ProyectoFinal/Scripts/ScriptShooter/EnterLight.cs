using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Luigi"))
        {
            LightRoom.active = true;
            Debug.Log("Luigi Entered.");
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Luigi"))
        {
            LightRoom.active = false;
            Debug.Log("Luigi Exit");
        }
    }
}
