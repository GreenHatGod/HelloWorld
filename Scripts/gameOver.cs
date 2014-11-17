using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	void OnGUI (){
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "Game Over");
		GUI.Label (new Rect (Screen.width / 2 - 40, 300,150, 80), "Holy Shovelware, Batman!");
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 350, 80, 60), "Play again")) {
			Application.LoadLevel (0);		
		}
	}
}
