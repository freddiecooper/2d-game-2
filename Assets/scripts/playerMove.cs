using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer sr;
    bool faceLeft=false; 
    public Sprite standSprite;
    public Sprite jumpSprite;
    public Sprite attackspite;
    public int lives = 1;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        
        
        if(Input.GetKeyDown ("up"))
        {           
            if(velocity.y == 0)
            {
                velocity.y = 40;
            }
        } 
          
        if (Input.GetKey("left"))
        {
            velocity.x = -10;
            faceLeft = true;
        }     
         

        if (Input.GetKey("right"))
        {
            velocity.x = 10;
            faceLeft = false;
        }
        rb.velocity = velocity;


        if (Input.GetKey("x"))
        {
            lives = 0;
        } 

        if( faceLeft == true )
        {
            
            transform.localScale = new Vector3(-1,1,1);
        }
        else
        {
            
            transform.localScale = new Vector3(1,1,1);
        }

        // animation


        if (velocity.y > 0.01f)
        {
            sr.sprite = jumpSprite;
        }

        else if (Input.GetKey("e"))
        {
            sr.sprite = attackspite;
        }

        else
        {
            sr.sprite = standSprite;
        }
          
    }
}

