using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentExample : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent((Renderer rx) =>
        {
            rx.material.color = Color.blue;
        });
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent((Rigidbody rigid) =>
        {
            rigid.AddForce(Vector3.up * 10);
        });
    }
}
