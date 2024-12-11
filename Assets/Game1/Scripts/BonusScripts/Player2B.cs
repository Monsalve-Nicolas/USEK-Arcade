using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2B : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb;
    public float spd;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnJoystickP2(Vector2 direccion)
    {
        rb.velocity = new Vector2(direccion.x * 0f, direccion.y * spd);
    }
    public void OnJump(bool value)
    {
        if(value) rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
