using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour {
    public float speed;
    public float jumpForce;
    bool mohsen;
    private Rigidbody2D rb2d;

    [SerializeField]
    LayerMask ground;
    void Start()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    { 
        float moveHorizontal = Input.GetAxis("Horizontal");

        mohsen = GetComponent<Collider2D>().IsTouchingLayers(ground);

        float x = Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime;

        rb2d.velocity = new Vector2(x, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && mohsen)
        {
            rb2d.AddForce(Vector2.up * jumpForce);

        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GameOver")
            SceneManager.LoadScene(2);
    }
}
