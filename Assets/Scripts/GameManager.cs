using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Pelota")]
    public GameObject pelota;

    [Header("Jugador1")]
    public GameObject jugador1;
    public GameObject PuntoAJugador1;

    [Header("Jugador2")]
    public GameObject jugador2;
    public GameObject PuntoAJugador2;

    [Header("Puntuaciones")]
    public GameObject Jugador1Texto;
    public GameObject Jugador2Texto;

    int Player1Score;
    int Player2Score;

    [Header("PanelesGanadores")]
    public GameObject ganaJugador1;
    public GameObject ganaJugador2;


    public bool IAGame;

    public void Player1Scored()
    {
        Player1Score++;
        Jugador1Texto.GetComponent<TMPro.TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();

        if (Player1Score == 10)
        {
            GanadorHasta10P1();
        }
    }

    public void Player2Scored()
    {
        Player2Score++;
        Jugador2Texto.GetComponent<TMPro.TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();

        if (Player2Score == 10)
        {
            GanadorHasta10P2();
        }
    }

    void ResetPosition()
    {
        if(IAGame)
        {
            pelota.GetComponent<MovmentPelota>().Reset();
            jugador1.GetComponent<PlayerMovment>().Reset();
        }
        else
        {
            pelota.GetComponent<MovmentPelota>().Reset();
            jugador1.GetComponent<PlayerMovment>().Reset();
            jugador2.GetComponent<PlayerMovment>().Reset();
        }
    }

    void GanadorHasta10P1()
    {
        ganaJugador1.SetActive(true);
        Time.timeScale = 0f;
    }

    void GanadorHasta10P2()
    {
        ganaJugador2.SetActive(true);
        Time.timeScale = 0f;
    }
}
