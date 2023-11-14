using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 _movement;
    private Rigidbody2D _rigidbody2D;
    // private Animator _animator;
    
    [Range(5f, 30f)]
    public float speed = 10f;
    
    private void Awake()
    {
        Debug.Log("Awake");

        _rigidbody2D = GetComponent<Rigidbody2D>();
        // _animator = GetComponent<Animator>();
    }

    void Start()
    {
        Debug.Log("Start");
    }

    private void Update()
    {
        
        // Compute the movement vector
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        _movement = new Vector2(x: horizontal, y: vertical).normalized;
        // _animator.SetFloat("Horizontal", horizontal);
        // _animator.SetFloat("Vertical", vertical);
        
        // _animator.SetFloat("Speed", _movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        // Move the player by applying a velocity to the rigidbody
        _rigidbody2D.velocity = _movement * speed;
    }
}