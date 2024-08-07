using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Button_Script : MonoBehaviour
{
    public void play_button_script()
    {
        SceneManager.LoadScene("Earth_scene");
    }

    public void quit_button_script()
    {
        Application.Quit();
    }

}
