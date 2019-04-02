using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleLookScript : MonoBehaviour
{
    public enum mode
    {
        LookAwayInstant,
        LookAwaySlow,
        LookTowardInstant,
        LookTowardSlow
    }

    public GameObject viewTarget;
    public mode ScriptMode;

    public float turnTime = 2f;

    float elapsed = 0f;
    Vector3 lastTargetPosition;
    Quaternion lookStartOrientation;
    Quaternion? lookEndOrientation;

    // Update is called once per frame
    void Update()
    {
        if (viewTarget.transform.position != lastTargetPosition)
        {
            elapsed = 0f;
            lastTargetPosition = viewTarget.transform.position;
            lookStartOrientation = transform.rotation;
            lookEndOrientation = null;
        }

        elapsed = Mathf.Min(elapsed + Time.deltaTime, turnTime); // Either add time, or sit at max if the target is stationary


        switch (ScriptMode)
        {
            case mode.LookTowardInstant:
                transform.LookAt(viewTarget); // Added a LookAt for a GameObject, instead of just the transform
                break;

            case mode.LookAwayInstant:
                transform.LookAwayFrom(viewTarget); // Works like LookAt, but looks away, handy for quads
                break;

            case mode.LookAwaySlow:
                if (lookEndOrientation == null) lookEndOrientation = transform.GetLookAwayFromRotation(viewTarget);
                transform.rotation = Quaternion.Slerp(lookStartOrientation, lookEndOrientation.Value, elapsed / turnTime);
                break;

            case mode.LookTowardSlow:
                if (lookEndOrientation == null) lookEndOrientation = transform.GetLookAtRotation(viewTarget);
                transform.rotation = Quaternion.Slerp(lookStartOrientation, lookEndOrientation.Value, elapsed / turnTime);
                break;
        }
    }
}
