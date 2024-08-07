using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(1); //Play Game Function
    }

    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu"); //takes user to settings menu
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); //takes user to main menu
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit(); //Quit Game Function
    }


    public class SoundManagaer: MonoBehaviour
    {
        [SerializeField] Slider volumeSlider;

        public void ChangeVolume()
        {
            AudioListener.volume = volumeSlider.value;
         }
    }

}


