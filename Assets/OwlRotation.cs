using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlRotation : MonoBehaviour
{
    private float timer = 2f;
    private float speed = 15;
    private void Update()
    {
        if (timer>0)
        {
            Debug.Log("hi");

            timer -= Time.deltaTime;
            transform.Rotate(Vector3.up * speed * Time.deltaTime);

        }

        if (timer<=0)
        {
            timer = 2;
            speed = -1 * speed;
        }
        
    }
}
