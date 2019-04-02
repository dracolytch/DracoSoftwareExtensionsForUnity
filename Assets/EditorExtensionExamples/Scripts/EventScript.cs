using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScript : MonoBehaviour {

    public UnityEventString MyStringEvent;

    public float delay = 1f;
    float elapsed = 0f;

    private void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= delay)
        {
            elapsed = 0f;
            gameObject.Invoke(MyStringEvent, "Test");
        }
    }

    public void PublicLog(string text)
    {
        Debug.Log(text);
    }
}
