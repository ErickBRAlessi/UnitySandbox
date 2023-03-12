using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private bool movementActive = true;
    [SerializeField] private bool rotationXActive = true;
    [SerializeField] private bool rotationYActive = false;

    private Vector2 movementValue;
    private Vector2 lookValue;
    private float totalXRotation = 0f;
    private float totalYRotation = 0f;

    // Update is called once per frame

    private void Awake(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnLook(InputValue value){
        lookValue = value.Get<Vector2>() * rotationSpeed;
    }

    public void OnMove(InputValue value){
        movementValue = value.Get<Vector2>() * movementSpeed;
    }

    private void Update(){
        if (movementActive){
            transform.Translate(movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime);
        }


        if (rotationXActive){
            totalXRotation += lookValue.x * Time.deltaTime;
        }

        if (rotationYActive){
            totalYRotation += -lookValue.y * Time.deltaTime;
        }

        transform.rotation = Quaternion.Euler(totalYRotation, totalXRotation, 0);
    }
}