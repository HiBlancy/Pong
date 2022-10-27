using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject panelDeOpciones;
    static bool JuegoPausado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoPausado)
            {
                VuelveAlJuego();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void VuelveAlJuego()
    {
        Time.timeScale = 1f;
        panelDeOpciones.SetActive(false);
        JuegoPausado = false;
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        panelDeOpciones.SetActive(true);
        JuegoPausado = true;
    }

    public void VolverAlMenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void UnoVSUno()
    {
        SceneManager.LoadScene("Game2J");
        Time.timeScale = 1f;
    }

    public void VSIA()
    {
        SceneManager.LoadScene("GameVsIA");
        Time.timeScale = 1f;
    }
}