using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kontrol : MonoBehaviour
{
    Rigidbody2D burung;
    public float lompat;
    float skor;

    float k;

    public Text teks_skor;

    public GameObject GameOver;

    public AudioSource music;

    public AudioSource meledak;
    
    void Start()
    {
        burung = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        teks_skor.text = "Skor Anda : " + skor;
        if(Input.GetMouseButtonDown(0))
        {
            burung.velocity = Vector2.up * lompat;
            music.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            skor++;
        }

        if(collision.gameObject.tag=="pipa")
        {
            Destroy(gameObject);
            GameOver.SetActive (true);
            k = 1;
                meledak.Play();
        }
    }
}
