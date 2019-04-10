using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentMissingExampleTwo : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent(
            (Rigidbody rb) => { Debug.Log("There's a RigidBody here where I didn't expect one"); },
            () => { Debug.Log("There's no RigidBody here, but I knew that was going to happen!"); }
        );
    }

}
