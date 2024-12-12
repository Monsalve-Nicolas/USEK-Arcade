using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltaPequeñaLangosta : MonoBehaviour
{

    public float jumpForce;
    public float spd;

    private bool isGrounded;
    private Rigidbody2D rb;
    private float horizontal;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    void Jump()
    {
        rb.AddForce(Vector3.up);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, rb.velocity.y);
    }
}
