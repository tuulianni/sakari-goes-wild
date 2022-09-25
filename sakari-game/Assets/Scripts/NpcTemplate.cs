using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTemplate : MonoBehaviour
{
    public Transform player;
    float x;
    float y;

    void Start()
    {
        // Take the x and y coordinates of this object
        x = transform.position.x;
        y = transform.position.y;
    }

    void Update()
    {
        // Map player coordinates to a new Vector
        Vector3 pPos = player.transform.position;
        // Check if the player is within +- 1 of this objects coordinates while the "Jump" key is pressed
        if (Input.GetButtonDown("Jump") && x + 1 > pPos.x && x - 1 < pPos.x && y + 1 > pPos.y && y - 1 < pPos.y)
        {
            // Here we want to spawn a new canvas with text boxes lj
            Debug.Log("Interact");
        }
    }
}
