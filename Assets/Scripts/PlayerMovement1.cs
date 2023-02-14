using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public float speed;
    private Rigidbody2D player1;
    private Rigidbody2D player2;
    private float directionY;
    private float directionY1;

    // Start is called before the first frame update
    void Start()
    {

        // get rigidbody of 2 players
        // we can put the Rigidbody2D as public and assign it in the inspector with a bool value that is a ref to one of the player
        /*
         * alternative code
         * 
         * public Rigidbody2D rb;
         * publuc bool isPlayer1;
         * public float speed;
         * private float movement;
         * 
         * 
         * void FixedUpdate()
         * if(isPlayer1){
         * movement = Input.GetAxisRaw("Vertical");
         * 
         * }
         * else {
         * movement = Input.GetAxisRaw("Vertical1");}
         * 
         * rb.velocity = new Vector2(rb.velocity.x ,movement * speed)
         
         */
        // must find a better way, since this way is not good in bigger games  
        player1 = GameObject.Find("player1").GetComponent<Rigidbody2D>();
        player2 = GameObject.Find("player2").GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    private void Update()
    {
        // up Arrow -> 1
        // down arrow -> -1

        // axes of player 1
        directionY = Input.GetAxisRaw("Vertical");

        // axes of player 2
        directionY1 = Input.GetAxisRaw("Vertical 1");
    }


    void FixedUpdate()
    {

        // Player 1
        // if player 1 presses above arrow -> move upwards
        if (directionY == 1)
        {

            player1.velocity = Vector3.up * speed;
           
        }
        // if player 1 presses bellow arrow -> move downwards
        else if (directionY == -1 )
        {
            player1.velocity = Vector3.down * speed;

        }





        // Player 2
        // if player 2 presses W key -> move upwards
        if (directionY1 == 1)
        {

            player2.velocity = Vector3.up * speed;

        }
        // if player 2 presses S key -> move downwards
        else if (directionY1 == -1)
        {
            player2.velocity = Vector3.down * speed;
        }

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
       
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        
    }
   

}
