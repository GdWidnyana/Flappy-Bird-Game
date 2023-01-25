using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    float x = 0;
    float waktu = 3;
    public GameObject pipa;


    void Update()
    {
        if(x<=0)
        {
            Instantiate(pipa, transform.position, Quaternion.identity);
            x = waktu;
        }
        else
        {
            x -= Time.deltaTime;
        }
    }
}
