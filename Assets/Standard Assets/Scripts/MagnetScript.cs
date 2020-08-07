using UnityEngine;
using System.Collections;

public class MagnetScript : MonoBehaviour {

    public Transform magnet;
    public float divider; // use this to reduce the magnets strength


	// Use this for initialization
	void Start () {

	}
	
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)                    

            other.attachedRigidbody.AddForce((magnet.position - other.transform.position)/ Vector3.Distance(magnet.position, other.transform.position)/divider, ForceMode.VelocityChange);
        
            
    }

    void OnTriggetEnter(Collider other)
    {
        Debug.Log("Magnet OnTriggerEnter triggered");
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Magnet OnTriggerExit triggered");
        
    }

    void FixedUpdate ()
    {
        
    }
	
}
