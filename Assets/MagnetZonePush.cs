using UnityEngine;
using System.Collections;

public class MagnetZonePush : MonoBehaviour
{
    // Attach this script to the trigger inside the windzone

    public float thrustX, thrustY, thrustZ; // use to control forces amount and direction

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {
        // applies the force to any object inside the windzone
        if (other.attachedRigidbody)
            other.attachedRigidbody.AddForce(new Vector3(thrustX, thrustY, thrustZ), ForceMode.Force);
    }
}
