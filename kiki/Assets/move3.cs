using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3 : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    void OnTriggerEnter2D(Collider2D collisionInfo)
    {

        GetComponent<Rigidbody2D>().velocity *= -1;
    }

    private void Start()
    {
        Debug.Log("Hello");
        GetComponent<Rigidbody2D>().velocity = Vector2.left* moveSpeed;
    }
    void Update()
    {
        Debug.Log("Hi");

    }
}