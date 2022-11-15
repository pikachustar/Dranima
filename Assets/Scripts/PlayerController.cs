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
    public Animator animator;

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

        if(moveX > 0) { //moving right...
            animator.SetBool("IsRight", true);
            animator.SetBool("IsMoving", true);
        } 
        else {
            animator.SetBool("IsRight", false);
        }

        if(moveX < 0) { //moving left...
            animator.SetBool("IsLeft", true);
            animator.SetBool("IsMoving", true);
        }
        else {
            animator.SetBool("IsLeft", false);
        }

        if(moveZ < 0) { //moving forward...
            animator.SetBool("IsFront", true);
            animator.SetBool("IsMoving", true);
        }
        else {
            animator.SetBool("IsFront", false);
        }

        if(moveZ > 0) { //moving back...
            animator.SetBool("IsBack", true);
            animator.SetBool("IsMoving", true);
        }
        else {
            animator.SetBool("IsBack", false);
        }

        if(moveSpeed == 0)
        {
            animator.SetBool("IsMoving", false);
            animator.SetBool("IsLeft", false); //TODO
        }

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
