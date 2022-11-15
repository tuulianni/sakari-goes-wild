using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveDirection;
    public float moveSpeed = 10;
    public float jumpForce = 1250;
    public bool isGrounded;
    private bool facingRight = true;
    public int MaxJumpCount = 2;
    
    void Update(){
    
        PlayerMove();
    }

    void PlayerMove(){
        //Controlls
        moveDirection = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump2") && MaxJumpCount > 0)
        {
            //MaxJumpCount--;
            Jump();
        }
        //Animation

         if (moveDirection > 0 && !facingRight){
            flipSakari();
        } else if (moveDirection < 0 && facingRight){
            flipSakari();
        }

        //Physics

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveDirection * moveSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump(){
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpForce);
        isGrounded = false;
        MaxJumpCount--;
        
    }
    private void flipSakari()
    {

        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    void OnCollisionEnter2D (Collision2D col){
       // Debug.Log("Player has collited with " + col.collider.name);
        if(col.gameObject.tag == "ground" || col.gameObject.tag == "Object" ||col.gameObject.tag == "roof"){
            isGrounded = true;
            MaxJumpCount = 2;
        }
    }


}