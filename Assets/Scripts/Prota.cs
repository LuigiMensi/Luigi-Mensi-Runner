using UnityEngine;

public class Prota : MonoBehaviour
{
    public float movSpeed = 5f;
    public float fuerzaSalto = 8f;


    public Animator animator;
    private Rigidbody2D rb;
    private float playerMov;
    //private bool estaSaltando = false;
    private bool estaMuerto = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (estaMuerto) return;
        Movimiento(); 
        Animaciones();
        Salto();
    }
    void Movimiento()
    {
        playerMov = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(playerMov * movSpeed * Time.deltaTime, 0, 0);

    }

    void Salto()
    {
        playerMov = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, playerMov * fuerzaSalto * Time.deltaTime, 0);
        if (playerMov != 0)
        {
            animator.SetBool("Saltando", true);
        }
        else
        {
            animator.SetBool("Saltando", false);
        }



    
    }


    void Animaciones()
    {
        if (playerMov < 0)
        {
            animator.SetBool("EstaCorriendoL", true);
            animator.SetBool("EstaCorriendoR", false);
        }
        else if (playerMov > 0)
        {
            animator.SetBool("EstaCorriendoR", true);
            animator.SetBool("EstaCorriendoL", false);
        }
        else
        {
            animator.SetBool("EstaCorriendoR", false);
            animator.SetBool("EstaCorriendoL", false);
        }

    }

    void Morir()
    {
        estaMuerto = true;
        rb.linearVelocity = Vector3.zero;
        animator.SetTrigger("Morir");
    }

}
