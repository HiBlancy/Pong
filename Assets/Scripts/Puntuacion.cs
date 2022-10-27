using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public bool puntoPara1Jugador;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pelota"))
        {
            if (puntoPara1Jugador)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }

            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}
