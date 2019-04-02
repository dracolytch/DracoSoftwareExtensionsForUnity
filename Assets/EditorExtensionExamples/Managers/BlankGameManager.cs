using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// An example class that would manage the game
public class BlankGameManager : MyGameBehavior
{
    public bool isPaused = true;

	// Use this for initialization
	void Start () {
        // With this reference to networkManager, 
        // this class will only look up a GameManager once, the first time
        // it's needed
        networkManager.ReadFromSite("http://www.site.com");
	}

}
