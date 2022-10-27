using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MovmentPelota : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Vector3 posicionInicial;

    public AudioSource golpe;

    void Start()
    {
        posicionInicial = transform.position;
        StartMovment();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            golpe.Play();
            speed = speed + 0.5f;
        } 
        if(collision.gameObject.tag == "Pala")
        {
 //           speed = speed + 0.5f;
        }
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = posicionInicial;
        StartMovment();
        Time.timeScale = 1f;
    }

    void StartMovment()
    {
        speed = 3f;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2 (speed * x, speed * y);
    }

}
