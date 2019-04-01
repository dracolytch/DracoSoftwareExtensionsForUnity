using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleLookScript : MonoBehaviour
{
    public GameObject viewTarget;
    public int t2;
    public RangeColor myColor5;

    // Update is called once per frame
    void Update()
    {
        // Look away from the target, handy for quads
        //transform.LookAwayFrom(viewTarget);

        // Where should I look to look at something?
        // You wouldn't do this, but it's an example of getitng the look rotation
        //transform.rotation = transform.GetLookAtRotation(viewTarget);

        // Get the rotation to look away from the target
        // You wouldn't do this, but it's an example of getitng the method
        transform.rotation = transform.GetLookAwayFromRotation(viewTarget);
    }
}
