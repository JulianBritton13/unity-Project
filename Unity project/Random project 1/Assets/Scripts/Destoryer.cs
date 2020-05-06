﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoryer : MonoBehaviour
{
    public float lifeTime = 10f;

    void Update()
    {
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                Destruction();
            }
        }

        if (this.transform.position.y <= -20)
        {
            Destruction();
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "Destroyer")
        {
            Destruction();
        }    
    }


    void Destruction()
    {
        Destroy(this.gameObject);
    }

}
