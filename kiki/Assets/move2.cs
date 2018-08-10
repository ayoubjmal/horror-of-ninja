using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // Destroy the whole Block
    }

    private void Start()
    {
        Debug.Log("Hello");
        GetComponent<Rigidbody2D>().velocity = Vector2.up * moveSpeed;
    }
    void Update()
    {
        Debug.Log("Hi");
        
    }
}