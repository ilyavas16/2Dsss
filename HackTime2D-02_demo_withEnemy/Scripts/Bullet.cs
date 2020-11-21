using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name); // для проверки, что наш буллет куда-то врезается
        Destroy(gameObject);
    }
}
