using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        // using invokeRepeating as a timer between object spawns
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // spawns the objects
    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stopSpawning)
        {
            // stops the timer for object spawning
            CancelInvoke("SpawnObject");
        }
    }

}
