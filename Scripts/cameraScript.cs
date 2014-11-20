using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	public Transform player;
	// Update is called once per frame
	void Update () {
		transform.position= new Vector3(player.position.x+3,0,-10);
	}
}
//This code makes the Camera keep going right.
