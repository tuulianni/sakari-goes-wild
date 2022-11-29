using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoundedNpc : MonoBehaviour
{

    private Vector3 directionVector;
    private Transform myTransform;
    public float speed;
    private Rigidbody2D myRigidBody;
    public Collider2D bounds;

 

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        myRigidBody = GetComponent<Rigidbody2D>();
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        //if(!playerInRange){}
            Moove();
        
        
    }

    void Moove()
    { 
        Vector3 temp = myTransform.position + directionVector * speed * Time.deltaTime;
        if (bounds.bounds.Contains(temp)){
            myRigidBody.MovePosition(temp);
        } 
        else
        {
            ChangeDirection();
        }
    }

    void ChangeDirection(){

        int direction = Random.Range(0,4);
        switch (direction)
        {
            
            case 0:
            //walking to the right
            directionVector = Vector3.right;
            break;
            case 1:
            //walking up
            directionVector = Vector3.up;
            break;
            case 2:
            //walking left
            directionVector = Vector3.left;
            break;
            case 3:
            //walking down
            directionVector = Vector3.down;
            break;
            default:

            break;
        }
    }
    private void OnCollisionEnter2D(Collision2D other){

        Vector3 temp = directionVector;
        ChangeDirection();
        int loops = 0;
        while(temp == directionVector && loops < 100){
            loops++;
            ChangeDirection();
        }

    }
}
