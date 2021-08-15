using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    // Any time the object hits any collider
    void OnCollisionEnter2D(Collision2D col)
    {
        // Whenever the player runs into me
        if (col.gameObject.tag == "Player")
        {
            // Destroy my gameobject
            Destroy(gameObject);
        }
    }
}
