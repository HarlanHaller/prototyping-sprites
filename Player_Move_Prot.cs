using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour
{
    public int playerSpeed = 10;
    public int playerJumpPower = 1250;

    private Rigidbody2D rd;
    private bool facingRight = true;
    private float moveX;

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
        if (Input.GetButtonDown("Jump")) {
            jump();
        }
        //TODO animation
        //player direction
        if (moveX > 0.0f && facingRight == false)
        {
            flipPlayer();
        }
        if (moveX < 0.0f && facingRight == true)
        {
            flipPlayer();
        }
        //phisics
        rd.velocity = new Vector2 (moveX * playerSpeed, rd.velocity.y);
    }

    void jump()
    {
        rd.AddForce(Vector2.up * playerJumpPower);
    }

    void flipPlayer() 
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
