using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; //Base movement
    public Rigidbody rb;
    private Vector3 moveDirection;
    public LayerMask grassLayer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        processedInput();
        run();
    }

    void FixedUpdate()
    {
        move();
        CheckForEncounters();
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

    private void CheckForEncounters()
    {
        if(Physics2D.OverlapCircle(transform.position, 0.2f, grassLayer) != null)
        {
            if (Random.Range(1, 101) <= 10)
            {
                Debug.Log("HOLY SHIT A WILD POKEMON");
            }
            else
            {
                Debug.Log("NOT WILD POKEMON");
            }

        }
    }
}
