using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_pipa : MonoBehaviour
{
    Rigidbody2D pipa;
    float vektor_y;
    void Start()
    {
        vektor_y = Random.Range(2.26f, -1.67f);
        transform.position = new Vector2(transform.position.x, vektor_y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Vector2.left * 50, Time.deltaTime * 3);
    }
}
