using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;
    public Rigidbody2D rd;

    void Start() {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    void playerMove()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        //TODO animation
        //player direction
        if (moveX < 0.0f && facingRight == false)
        {
            flipPlayer();
        }
        if (moveX <0.0f && facingRight == true)
        {
            flipPlayer();
        }
        //phisics
        rd.velocity = new Vector2 (moveX * playerSpeed, rd.velocity.y);
    }

    void jump()
    {
        //TODO jumping code
    }

    void flipPlayer() 
    {

    }
}
