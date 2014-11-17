using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public bool jump;
	public int height;
	//I was trying to do some animations but I couldn't figure out how to make them play, so just ignore these

	void Start () {
		jump= false;
		height = 0;
	}
	

	void Update () {
if (Input.GetKey(KeyCode.Space))
	rigidbody2D.AddForce(new Vector3 (0, 5, 0));
//this makes you fly, I couldn't get him to just jump
		jump = true;
	}

void FixedUpdate(){
		rigidbody2D.AddForce(new Vector3 (5, 0, 0));
		//This makes you keep going.
	}

}

