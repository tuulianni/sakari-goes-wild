using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RexMovement : MonoBehaviour
{
    float MoveDirectionX;
    [SerializeField]
    public float EnemySpeed;
    Rigidbody2D rb;
    //bool facingRight = false;
    Vector3 localScale;
   
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D> ();
        MoveDirectionX = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast;
        rb.velocity = new Vector2 (MoveDirectionX * EnemySpeed,rb.velocity.y);
       // if (hit.distance < 0.7f){
           // Destroy (hit.collider.gameobject);
       // }
    }


    void OnTriggerEnter2D (Collider2D col)
    {
    switch (col.tag)
    {
        case "Object":
        rb.AddForce (Vector2.up * 120f);
        break;
        case "Trigger":
        rb.AddForce (Vector2.up * 350f);
        //destroyes ohjects in its path
        ;
        break;
        
    }

    }
}