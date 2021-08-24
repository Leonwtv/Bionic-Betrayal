using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //Selects next scene in scene que
    public void PlayGame()
    {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Closes application
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
