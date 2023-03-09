using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemy;
    [SerializeField] private float startTime;
    [SerializeField] private float endTime;
    [SerializeField] private float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    void Spawn()
    {
        enemy.ForEach(e => Instantiate(e, transform.position, transform.rotation));
    }
    

    // Update is called once per frame
    void Update() { }
}