using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PanelPause;

    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            PanelPause.SetActive (true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            PanelPause.SetActive (false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }
}