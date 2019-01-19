using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// An example class that would skip working with the network
public class AlternateNetworkManager : BlankNetworkManager {

	// Use this for initialization
	void Start () {
        Debug.Log("I'm an stand-in, used for testing!");
	}
	
    public override void ReadFromSite(string url)
    {
        Debug.Log("Reading from disk instead of from url... ");
        // Do disk stuff here
    }
}
