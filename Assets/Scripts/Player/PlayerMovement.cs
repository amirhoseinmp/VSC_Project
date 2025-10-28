using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 0;
    private Vector2 _Direction;

    public InputActionReference PlayerGeneralMovement;

    void Start()
    {
        
    }

    void Update()
    {
        _Direction = PlayerGeneralMovement.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(_Direction.x * MoveSpeed, _Direction.y * MoveSpeed);
    }
}
