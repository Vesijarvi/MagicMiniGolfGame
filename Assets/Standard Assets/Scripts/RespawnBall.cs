using UnityEngine;
using System.Collections;
using UnityStandardAssets.Cameras;

public class RespawnBall : MonoBehaviour {
    public GameObject SpawnEmptyObject;
	Transform spawnPoint;
    Transform camspawnpoint;
    public PivotBasedCameraRig cam;




    // Use this for initialization
    void Start() {
        SpawnEmptyObject = GameObject.Find("Respawnpoint");
        spawnPoint = SpawnEmptyObject.GetComponent<Transform>();

        camspawnpoint = GameObject.Find("camerarespawn").transform;

    }

	void reSpawn() {

        Vector3 newPos = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;        
        transform.position = newPos;
        newPos = new Vector3(camspawnpoint.position.x, camspawnpoint.position.y, camspawnpoint.position.z);
        GameObject.Find("FreeLookCameraRig").transform.position = newPos;
        
	}

	// Update is called once per frame
	void Update () {
        
        //Debug.Log("BallTransform: " + TheBallTransform.position.y);
        if (gameObject.transform.position.y < -20)
        {
            reSpawn();
            UI_Script.Instance.MinusBall();
        }
        
	}
}

