using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI: MonoBehaviour
{

    public GameObject pauseMenu;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MyPause();

        }
    }

    public void MyPause()
    {
        if (isPaused)
        {
            if (pauseMenu) pauseMenu.SetActive(false);
            Time.timeScale = 1.0f;
            isPaused = !isPaused;
        }
        else
        {
            if (pauseMenu) pauseMenu.SetActive(true);
            Time.timeScale = 0.0f;
            isPaused = !isPaused;

        }

    }
}
