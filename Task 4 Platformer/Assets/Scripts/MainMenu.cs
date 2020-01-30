using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayMapSellect()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGameSellect()
    {
        Debug.Log("Game Quit");
    }

    public void BackSellect()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayCity()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayPolar()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayDesert()
    {
        SceneManager.LoadScene(4);
    }
}
