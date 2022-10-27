using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public bool isPlayer1; //Asignaremos quien es juagdor 1 y no en el inspector para decidir quien es quien ante las flechas o W-S
    public float speed;
    public Rigidbody2D rb;
    public Vector3 posicionInicial;

    float movimiento;
   
    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (isPlayer1)
        {
            movimiento = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movimiento = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x , movimiento * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = posicionInicial;
        Time.timeScale = 1f;
    }

}
