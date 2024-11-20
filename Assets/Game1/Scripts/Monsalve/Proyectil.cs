using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boss") == true)
        {
            Boss boss = collision.GetComponent<Boss>();
            boss.TakeDamge(damage);
        }
    }
}
