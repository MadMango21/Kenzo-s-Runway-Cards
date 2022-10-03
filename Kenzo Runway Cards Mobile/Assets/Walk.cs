using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Walk : MonoBehaviour
{
    CharacterController characterController;
    
    public float speed = 6.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveDirection = new Vector3(0.0f, 0.0f, 6.0f);
            moveDirection *= speed;
        }

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
