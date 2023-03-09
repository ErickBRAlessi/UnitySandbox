using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shootPoint;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //just trigger once, even if held (opposite of get key)
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            var clone = Instantiate(bullet);
            clone.transform.rotation = shootPoint.transform.rotation;
            clone.transform.position = shootPoint.transform.position;
            
        }
    }
}