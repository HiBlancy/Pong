using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed = 3;

    public GameObject pelota;
    Vector2 posicionPelota;


    void Update()
    {
        Move();
    }

    void Move()
    {
        posicionPelota = pelota.transform.position;

        if(transform.position.y > posicionPelota.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }

        if(transform.position.y < posicionPelota.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }
}
