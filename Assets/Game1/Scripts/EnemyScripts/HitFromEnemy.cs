using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFromEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("Da�o");
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
