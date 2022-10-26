using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physic_test : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent< Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    
   
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ourRigidbody.AddExplosionForce(10000,transform.position+ Vector3.back,2);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
    }
}
