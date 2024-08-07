using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Scene_Script : MonoBehaviour
{

    string buttonSceneToLoad = "Earth_scene";

    public void change_scene_mars()
    {
        buttonSceneToLoad = "Mars_Scene_Lewis";
        Debug.Log("This function ran!");
        Debug.Log(Lander_Door_Controller_Script.sceneToLoad + " -> " + buttonSceneToLoad);
        Lander_Door_Controller_Script.sceneToLoad = buttonSceneToLoad;
    }

    public void change_scene_earth()
    {
        buttonSceneToLoad = "Earth_scene";
        Debug.Log("This function ran!");
        Debug.Log(Lander_Door_Controller_Script.sceneToLoad + " -> " + buttonSceneToLoad);
        Lander_Door_Controller_Script.sceneToLoad = buttonSceneToLoad;
    }
}
