using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_Change_Script : MonoBehaviour
{
    string buttonSceneToLoad = "Earth_scene";

    public void change_scene()
    {
        Debug.Log("This function ran!");
        Debug.Log(Lander_Door_Controller_Script.sceneToLoad + " -> " + buttonSceneToLoad);
        Lander_Door_Controller_Script.sceneToLoad = buttonSceneToLoad;
    }

}
