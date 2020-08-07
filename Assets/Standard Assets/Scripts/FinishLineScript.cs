using UnityEngine;
using System.Collections;

public class FinishLineScript : MonoBehaviour {
    public UnityEngine.UI.Text YouWin;

    void OnTriggerEnter(Collider other) {
		if (other.attachedRigidbody)
			Debug.Log ("You win!");
        YouWin.enabled = true;


	}
}
