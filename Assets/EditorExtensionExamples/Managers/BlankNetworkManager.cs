using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// An example class that would manage the network
public class BlankNetworkManager : MyGameBehavior
{
	
	public virtual void ReadFromSite(string url)
    {
        Debug.Log("Reading from url... " + url);
        // do other network stuff here
    }
}
