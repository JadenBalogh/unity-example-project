using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputDirection = Input.GetAxis("Horizontal");
        transform.position += inputDirection * new Vector3(1f, 0, 0) * Time.deltaTime * speed;
    }
}
