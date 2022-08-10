using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bird : MonoBehaviour
{
    Rigidbody2D Rigi;

    public float Jumping_Power;
    public float Stooping_Power;

    public GameObject Over_PNL;

    void Start()
    {
        Rigi = GetComponent<Rigidbody2D>();
    }

   private void OnCollisionEnter2D()
    {
        Time.timeScale = 0.0f;
        Over_PNL.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigi.velocity = Vector2.zero;

            Rigi.velocity = Vector2.up * Jumping_Power * Time.deltaTime;

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 40.0f);
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Stooping_Power);
        }
    }
}
