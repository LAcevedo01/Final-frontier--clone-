using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Display_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject earthButton = GameObject.Find("button");
        earthButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
