using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    public float spawnFreq;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnFreq);
    }

    void Spawn()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.y = Random.Range(-0.6f, 2f);
        Instantiate(obstaclePrefabs, spawnPos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
