using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{


    public GameObject ball;
    public GameObject ball2;
    int gun;
    public float speedX = 2f;
    float speedY = 0f;
    private Rigidbody2D rb;



    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        gun = 1;

        

    }

    // Update is called once per frame
    void Update()
    {

        qualArma();
        trigger();

        }






    void qualArma()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun = 2;
        }

    }

    void trigger()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            if (gun == 1)
            {

                GameObject meuNovoTiro = Instantiate(ball, transform.position, Quaternion.identity);
                meuNovoTiro.GetComponent<Rigidbody2D>().velocity = new Vector2(speedX, speedY);
                Destroy(meuNovoTiro.gameObject, 1.5f);
            }

            else
            {
                GameObject meuNovoTiro = Instantiate(ball2, transform.position, Quaternion.identity);
                meuNovoTiro.GetComponent<Rigidbody2D>().velocity = new Vector2(speedX, speedY);
                Destroy(meuNovoTiro.gameObject, 1.5f);
            }


        }
    }



}


    






