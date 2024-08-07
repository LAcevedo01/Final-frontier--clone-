using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor_Controller_Script : MonoBehaviour
{
    public bool isDisplayed = false;
    
    public void Start()
    {
        GameObject menu = GameObject.Find("Fuel_Gauge_and_Planet_Select");
        //GameObject earthButton = GameObject.Find("Earth_Button");
        //disableButton(earthButton);
        menu.GetComponent<Renderer>().enabled = isDisplayed;

        
    }
    //This is where the action of displaying the menu will occur!
    public void displayMenu()
    {
        GameObject menu = GameObject.Find("Fuel_Gauge_and_Planet_Select");
        //GameObject earthButton = GameObject.Find("Earth_Button");
        Debug.Log("Menu will be displayed!");
        if (isDisplayed == false)
        {
            menu.GetComponent<Renderer>().enabled = isDisplayed;
            Button_Controller_Script.showMenu = false;
            //disableButton(earthButton);
            movement.playerCanMove = true;
            isDisplayed = true;
        }
        else
        {
            menu.GetComponent<Renderer>().enabled = isDisplayed;
            //enableButton(earthButton);
            isDisplayed = false;
            Button_Controller_Script.showMenu = true;
            movement.playerCanMove = false;
        }
        
    }

}
