using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenucode : MonoBehaviour
{
    public GameObject canvas;

    public void setting()
    {
        if(Time.timeScale == 1)
        {
            canvas.SetActive (true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            canvas.SetActive (false);
        }
    }

    public void PlayGame()
    {
        Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    
}
