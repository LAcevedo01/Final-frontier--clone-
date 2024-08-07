using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu_Script : MonoBehaviour
{
    public bool GamePaused;

    public GameObject pauseMenuUI;
    public void Start()
    {
        pauseMenuUI = GameObject.Find("PauseMenu");
        Resume();
    }
    
    //pauseMenuUI.GetComponent<Canvas>();
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void resume_game()
    {
        GameObject pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.GetComponent<Canvas>();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Button was pressed!");
    }

    public void quit_game()
    {
        SceneManager.LoadScene("Main Menu (Last Frontier)");
    }

    public void Resume()
    {
        Debug.Log("This script ran!");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        Debug.Log("This script ran!");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

}
