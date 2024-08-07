using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Base_Controller_Script : MonoBehaviour
{
    public static bool isOpen = false;
    public Scene currentScene;
    public static string sceneName;

    public void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        Debug.Log(sceneName);
    }

    public void OpenBase()
    {
        if (!isOpen)
        {  
            isOpen = true;
            SceneManager.LoadScene("Lander_Interior");
            isOpen = false;
        }
    }

    
}
