using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public Transform player;
    Vector3 range;

    void Awake()
    {
        //Calculate the range between the Camera's position and the Bird's position
        range = transform.position - player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make the Camera follow the Bird's movement on the X axis
        //And keep the y position constant
        transform.position = new Vector3(range.x + player.position.x, transform.position.y, range.z + player.position.z);
    }
}

  