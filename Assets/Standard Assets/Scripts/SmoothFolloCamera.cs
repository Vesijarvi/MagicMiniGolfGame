using UnityEngine;
using System.Collections;

public class SmoothFolloCamera : MonoBehaviour {

    public GameObject TheBall;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - TheBall.transform.position;
    }

    // LateUpdate is also called once per frame
    // It is quaranteed to run after all items have been processed in the update
    // This way we know for sure the ball has moved
	void LateUpdate () {
        transform.position = TheBall.transform.position + offset;
	}
}
