using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentExampleTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Works fine with 0+ elements, so all "GetComponents[Whatever]" methods work great
        gameObject.GetComponentsInChildren<Renderer>().ForEachComponent((Renderer r) =>
        {
            r.material.color = Color.green;
        });

	}
	

}
