using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    Main main;

    void Start()
    {
        float Y_Axis = Random.Range(-4.75f, -1.76f);
        transform.position = new Vector3(3.52f, Y_Axis, transform.position.z);

        main = GameObject.Find("Main").GetComponent<Main>();
    }

    
    void Update()
    {
        if (transform.position.x <= -4.74f)
        {
            main.Increase_Score(10);
            Destroy(gameObject);
        }

        transform.Translate(-3.5f * Time.deltaTime, 0, 0);
    }

}
