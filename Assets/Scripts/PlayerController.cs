using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 70f;
    private Rigidbody2D rb;

    private bool faceRight = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 4000);
        }

        if (moveX > 0 && !faceRight)
        {
            Flip();
        }
        else if(moveX < 0 && faceRight)
        {
            Flip();
        }

        void Flip()
        {
            faceRight = !faceRight;
            transform.localScale = new Vector3(transform.localScale.x * -1, 
                transform.localScale.y, transform.localScale.z);
        }
    }
}
