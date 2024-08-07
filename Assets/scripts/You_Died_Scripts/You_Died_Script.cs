using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class You_Died_Script : MonoBehaviour
{

    public static bool youDiedDisplayed = false;
    public GameObject youDiedCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You Died!");
        youDiedCanvas = GameObject.Find("You_Died_Screen");
        youDiedCanvas.SetActive(youDiedDisplayed);
    }

    // Update is called once per frame
    void Update()
    {
        youDiedCanvas.SetActive(youDiedDisplayed);
    }

    public void restart_level()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        youDiedDisplayed = false;
        youDiedCanvas.SetActive(youDiedDisplayed);
    }

    public void return_to_menu()
    {
        SceneManager.LoadScene("Main Menu (Last Frontier)");
        youDiedDisplayed = false;
        youDiedCanvas.SetActive(youDiedDisplayed);
    }
}
