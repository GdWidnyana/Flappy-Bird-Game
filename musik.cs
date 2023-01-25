using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musik : MonoBehaviour
{
    public AudioSource music;


    public void mulai()
    {
        music.Play();

    }

    public void stop()
    {
        music.Stop();
    }
   
}
