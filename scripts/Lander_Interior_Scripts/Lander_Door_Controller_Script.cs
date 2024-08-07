using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lander_Door_Controller_Script : MonoBehaviour
{
    public bool isOpen = false;
    public static string sceneToLoad;

    public void Start()
    {
        //Here, we need to get the current scene variable from the lander in the gamescene
        sceneToLoad = Base_Controller_Script.sceneName;
        //sceneToLoad = "Hello";

    }

    public void Update()
    {
        Debug.Log(sceneToLoad);
    }


    public void OpenBase()
    { 
        if (!isOpen)
        {
            isOpen = true;
            SceneManager.LoadScene(sceneToLoad);
            isOpen = false;
        }
    }
}
