using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Gameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Setting");
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
