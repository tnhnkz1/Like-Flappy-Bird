using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x <= -3.84f)
        {
            float Y_Axis = Random.Range(4.22f, -0.92f);

            transform.position = new Vector3(3.84f, Y_Axis, transform.position.z);
        }

        transform.Translate(-0.5f * Time.deltaTime, 0, 0);
    }
}
