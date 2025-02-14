using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    
    public static bool GamePaused = false;

    public GameObject pauseMenuUI;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
}
void Resume ()
{
    pauseMenuUI.SetActive(false);
    Time.timeScale =1f;
    GamePaused = false;
}

void Pause()
{
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GamePaused = true;
}

}
