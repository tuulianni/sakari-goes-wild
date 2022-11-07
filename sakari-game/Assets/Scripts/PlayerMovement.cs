using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 3f;
    public Vector2 movement;
    public new Rigidbody2D rigidbody;

    public Animator anim;
    public float hf = 0.0f;
    public float vf = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();

    }

    // FixedUpdate is called a fixed 50 times per second
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movementSpeed * Time.fixedDeltaTime * movement);
    }
    // Update is called once per frame
    void Update()
    {
        // We use "Jump" as the interact key in the top down world. No idea if this is actually the correct place for this...
        // Probably need to put this sort of check to the prefabs we want to be able to interact with
        //if (Input.GetButtonDown("Jump"))
        //{
        //    Debug.Log("Interact");
        //}

        movement.x = Input.GetAxisRaw("Horizontal"); // -1 when moving left, 1 when moving right
        movement.y = Input.GetAxisRaw("Vertical"); // -1 when moving down, 1 when moving up
        movement = movement.normalized; // Prevent movement speed increasing when moving diagonally

        hf = movement.x > 0.01f ? movement.x : movement.x < -0.01f ? 1 : 0;
        vf = movement.y > 0.01f ? movement.y : movement.y < -0.01f ? 1 : 0;

        // This flips the animation of moving left to moving right based on movement.x
        if (movement.x < -0.01f)
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

        anim.SetFloat("Horizontal", hf);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", vf);
        
    }

}
