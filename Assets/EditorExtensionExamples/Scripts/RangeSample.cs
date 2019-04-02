using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeSample : MonoBehaviour {

    public RangeInt IntegerRange;
    public RangeFloat FloatRange;
    public RangeColor ColorRange;

    private void Update()
    {
        Debug.Log(IntegerRange.RandomInRange());
        Debug.Log(FloatRange.RandomInRange());
        Debug.Log(ColorRange.RandomInRange());
    }
}
