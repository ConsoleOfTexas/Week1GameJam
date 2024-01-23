using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // When clicked, the game starts in the first level
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }

    // When clicked, the game will be terminated
    public void Quit()
    {
        Application.Quit();
    }
}
