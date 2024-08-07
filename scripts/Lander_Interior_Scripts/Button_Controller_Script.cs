using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Controller_Script : MonoBehaviour
{

    public static string sceneToLoad;

    public GameObject Planet_Select_UI;
    public static bool showMenu = false;

    public void Start()
    {
        Planet_Select_UI = GameObject.Find("Planet_Select_UI");
    }

    public void Update()
    {
        if(showMenu == true)
        {
            Planet_Select_UI.SetActive(showMenu);
        }
        else
        {
            Planet_Select_UI.SetActive(showMenu);
        }
    }

    public void earth_button_function()
    {
        Lander_Door_Controller_Script.sceneToLoad = "Earth_scene";
    }

    public void mars_button_function()
    {
        Lander_Door_Controller_Script.sceneToLoad = "Mars_Scene_Lewis";
    }

}
