using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballmove : MonoBehaviour
{
    int timer = 0;
    int direction = 15;
    Rigidbody2D rb;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        direction = -direction;
        timer++;
        //Debug.Log(timer);

        if(timer>200)
        {
            timer = 0;
            rb.velocity = new Vector2(direction,0);
        }
    }
}
