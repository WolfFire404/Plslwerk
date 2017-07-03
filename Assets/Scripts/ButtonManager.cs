using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }
    //public void Game()
    //{
    //    SceneManager.LoadScene("mainScene");
    //}
    //public void Win()
    //{
    //    SceneManager.LoadScene("Win");
    //}
    public void Exit()
    {
        Application.Quit();
    }
}
