using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class playerControler : MonoBehaviour
{
    public float walkSpeed;
    
    Vector3 moveInput = Vector3.zero;
    CharacterController characterController;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();

    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveInput = transform.TransformDirection(moveInput) * walkSpeed;

        characterController.Move(moveInput * Time.deltaTime);

    }
}