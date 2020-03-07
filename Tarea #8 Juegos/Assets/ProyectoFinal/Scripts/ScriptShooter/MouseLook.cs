using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform carlBody;
    float xRotation = 0f;
    bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        //if (!paused)
        //{
        //    Cursor.lockState = CursorLockMode.Locked;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        carlBody.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused=!paused;
            print(paused);

        }
        if (!paused)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    } 

}
