using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public float spawnAreaSize = 1;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // creates a random location with the size of spawnAreaSize
            float x = Random.Range(-1f, 1f) * spawnAreaSize;
            float z = Random.Range(-1f, 1f) * spawnAreaSize;
            Vector3 spawnArea = transform.right * x + transform.forward * z + spawnPos.position;

            // Spawns the spawnee at the spawnArea location
            Instantiate(spawnee, spawnArea, spawnPos.rotation);
        }
    }
}
