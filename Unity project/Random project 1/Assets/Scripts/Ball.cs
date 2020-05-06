using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float lifeTime = 10f;
    public bool inWindZone = false;
    public GameObject windZone;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (lifeTime > 0)
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

    private void FixedUpdate()
    {
        if (inWindZone)
        {
            rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
        }
    }
    // check if ball enters the wind zone
    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "windArea")
        {
            windZone = coll.gameObject;
            inWindZone = true;
        }
    }
    //check is ball exits the wind zone
    private void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "windZone")
        {
            inWindZone = false;
        }
    }

    // check is ball enters despawn zone
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Destroyer")
        {
            Destruction();
        }
    }

    // destroys the object
    void Destruction()
    {
        Destroy(this.gameObject);
    }



}
