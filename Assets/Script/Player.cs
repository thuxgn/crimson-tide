using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    private Rigidbody2D rb;
    private void HandleMovement()
    {
        Vector2 moveInput = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            moveInput.y = 1;

        if (Keyboard.current.sKey.isPressed)
            moveInput.y = -1;

        if (Keyboard.current.aKey.isPressed)
            moveInput.x = -1;

        if (Keyboard.current.dKey.isPressed)
            moveInput.x = 1;

        // Chuẩn hóa hướng di chuyển
        Vector2 movement = moveInput.normalized;

        // Di chuyển nhân vật
        rb.linearVelocity = movement * moveSpeed;


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        HandleMovement();
    }
}