using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2move : MonoBehaviour
{

    public int lives = 1;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity1 = rb.velocity;
        velocity1.x = 0;
        velocity1.y = 35;
        
        if(Input.GetKeyDown ("space"))
        {
            rb.velocity = velocity1;
        } 

        Vector2 velocity2 = rb.velocity;
        velocity2.x = -10;
            
        if (Input.GetKey("a"))
        {
            rb.velocity = velocity2;
        }

        Vector2 velocity3 = rb.velocity;
        velocity3.x = 10;
         
        if (Input.GetKey("d"))
        {
            rb.velocity = velocity3;
        }   

        if (Input.GetKey("x"))
        {
            lives = 0;
        }
    }
}