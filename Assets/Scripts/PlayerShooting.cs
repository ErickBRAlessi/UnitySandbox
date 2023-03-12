using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerShooting : MonoBehaviour{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shootPoint;

    // Start is called before the first frame update
    void Start(){ }

    // Update is called once per frame
    public void OnFire(InputValue value){
        if (value.isPressed){
            var clone = Instantiate(bullet);
            clone.transform.rotation = shootPoint.transform.rotation;
            clone.transform.position = shootPoint.transform.position;
        }
    }
}