using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onPlay()
    {
        // Loads the first scene.
        SceneManager.LoadScene("Level1");
    }

    public void onQuit()
    {
        Debug.Log("Application Quit");
        Application.Quit();
    }
}
