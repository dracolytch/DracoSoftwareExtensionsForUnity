using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, 2f * Mathf.Cos(Time.realtimeSinceStartup) * Time.deltaTime);
	}
}
