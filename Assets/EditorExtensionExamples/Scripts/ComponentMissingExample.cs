using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentMissingExample : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Fails silently if the component isn't there
        gameObject.GetComponent((Renderer r) =>
        {
            r.material.color = Color.black;
        });

        // Fails with a debug error if the component isn't there
        gameObject.GetComponentRequired((Renderer r) =>
        {
            r.material.color = Color.black;
        });
	}

}
