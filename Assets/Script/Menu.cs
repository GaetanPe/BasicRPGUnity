using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("ChooseClassScene");
    } 
    public void Exit()
    {
        Application.Quit();
    }
}
