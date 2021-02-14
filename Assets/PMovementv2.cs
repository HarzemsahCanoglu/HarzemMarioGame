using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovementv2 : MonoBehaviour
{
    public float thrust = 1.0f;
    private Rigidbody2D rigidbody2;
    public bool canJump = false;

    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Hell yeah it works");
            rigidbody2.AddForce(transform.right * -1 * thrust);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Hell yeah it works");
            rigidbody2.AddForce(transform.right * thrust);
        }

        if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        {
            Debug.Log("Hell yeah it works");
            rigidbody2.AddForce(transform.up * thrust);
            canJump = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Yeah BOIII");
        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("We're on the ground");
            canJump = true;
        }
    }
}