using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private bool movementActive = true;

    [SerializeField] private float rotationSpeed;
    
    [SerializeField] private bool rotationXActive = true;
    [SerializeField] private bool rotationYActive = true;

    private float totalXRot = 0f;

    private float totalYRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var normalizedSpeed = movementSpeed * Time.deltaTime;
        var normalizedRotation = rotationSpeed * Time.deltaTime;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,normalizedSpeed);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,-normalizedSpeed);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-normalizedSpeed,0,0);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(normalizedSpeed,0,0);
        }

        if (rotationXActive)
        {
            var mouseX = Input.GetAxis("Mouse X");
            totalXRot += mouseX * normalizedRotation;
        }
        
        if (rotationYActive)
        {
            var mouseY = Input.GetAxis("Mouse Y");
            totalYRot += -mouseY * normalizedRotation;
        }
        transform.rotation = Quaternion.Euler(totalYRot, totalXRot, 0f);


    }
}
