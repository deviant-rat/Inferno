using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveDir;

    private float moveX;
    private float moveY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        if(moveX != 0)
        {
            moveY = 0;
        }
        moveDir.x = moveX;
        moveDir.y = moveY;
        moveDir.Normalize();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDir * speed * Time.fixedDeltaTime);
    }
}
