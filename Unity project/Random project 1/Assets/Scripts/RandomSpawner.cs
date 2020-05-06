using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject[] spawnees;
    public Transform spawnPos;

    int randomInt;

    public float spawnAreaSize = 1;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SpawnRandom();
        }
    }

    void SpawnRandom()
    {
        // create a random Int for which spawnee is going to spawn
        randomInt = Random.Range(0, spawnees.Length);

        // creates a random location with the size of spawnAreaSize
        float x = Random.Range(-1f, 1f) * spawnAreaSize;
        float z = Random.Range(-1f, 1f) * spawnAreaSize;
        Vector3 spawnArea = transform.right * x + transform.forward * z + spawnPos.position;

        // Spawns the spawnee at the spawnArea location
        Instantiate(spawnees[randomInt], spawnArea, spawnPos.rotation);
    }
}
