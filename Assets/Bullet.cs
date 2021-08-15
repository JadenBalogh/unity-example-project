using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Any time the bullet hits any collider
    void OnTriggerEnter2D(Collider2D col)
    {
        // If the bullet hits an enemy
        if (col.gameObject.tag == "Enemy")
        {
            // Destroy the bullet
            Destroy(gameObject);
            // Destroy the enemy
            Destroy(col.gameObject);
        }
    }
}
