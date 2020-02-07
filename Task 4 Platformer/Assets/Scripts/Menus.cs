using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void LoadMaps()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadCity()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadDesert()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadPolar()
    {
        SceneManager.LoadScene(2);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
