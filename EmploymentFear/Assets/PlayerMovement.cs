using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value in the Inspector
    private Rigidbody2D rb;
    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input for horizontal and vertical movement
        moveInput.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right Arrow keys
        moveInput.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down Arrow keys

        // Normalize the input vector to prevent faster diagonal movement
        moveInput.Normalize();
    }

    void FixedUpdate()
    {
        // Apply movement using Rigidbody2D velocity
        rb.velocity = moveInput * moveSpeed;
    }
}
