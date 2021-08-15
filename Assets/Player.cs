using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        // Left-right movement
        float inputDirection = Input.GetAxis("Horizontal");
        transform.position += inputDirection * new Vector3(1f, 0, 0) * Time.deltaTime * speed;

        // If the user left-clicks
        if (Input.GetButtonDown("Fire1"))
        {
            // Spawn a bullet
            Vector3 spawnPos = transform.position + new Vector3(1f, 0, 0);
            GameObject bullet = Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 0);
        }
    }
}
