using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cubecontrol : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += speed * Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, 5f);
        }




    }
}
    

