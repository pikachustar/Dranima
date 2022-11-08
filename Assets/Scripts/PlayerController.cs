using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; //Base movement
    public Rigidbody rb;
    private Vector3 moveDirection;
    public LayerMask grassLayer;

    public event Action OnEncountered;

    void Start()
    {

    }

    // Update is called once per frame
    public void HandleUpdate()
    {
        processedInput();
        run();
    }

    void FixedUpdate()
    {
        move();
    }

    void processedInput() {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(moveX, 0f, moveZ).normalized;
    }

    void move() 
    {
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, 0f, moveDirection.z* moveSpeed);
    }

    void run() 
    {
        if(Input.GetKey(KeyCode.LeftShift)) //Sprint
        {
            moveSpeed = 75;
        }
        else{
            moveSpeed = 50;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (UnityEngine.Random.Range(1, 101) <= 10)
        {
            OnEncountered();
        }
    }
}
