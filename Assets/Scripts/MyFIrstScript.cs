using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFIrstScript : MonoBehaviour
{
    [SerializeField]
    private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        print(velocity);
    }

    // Update is called once per frame
    void Update()
    {
        print("update");
    }

    void OnDestroy()
    {
        print("destroyed");
    }
}
