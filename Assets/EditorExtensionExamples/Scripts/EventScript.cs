using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScript : MonoBehaviour {

    public UnityEventString MyStringEvent;

    UnityEventString myNullEvent = null;

    public float delay = 1f;
    float elapsed = 0f;

    private void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= delay)
        {
            elapsed = 0f;
            gameObject.Trigger(MyStringEvent, "Test");
            gameObject.Trigger(myNullEvent, "This should fail!");
        }
    }

    public void PublicLog(string text)
    {
        Debug.Log(text);
    }
}
