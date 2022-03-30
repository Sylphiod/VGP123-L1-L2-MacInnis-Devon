using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;

    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float jumpSpeed = 3f;

    float keyHorizontal;
    bool keyJump;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        keyHorizontal = Input.GetAxisRaw("Horizontal");
        keyJump = Input.GetKeyDown(KeyCode.Space);
        rb2d.velocity = new Vector2(keyHorizontal * moveSpeed, rb2d.velocity.y);
        if (keyJump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
    }
}
