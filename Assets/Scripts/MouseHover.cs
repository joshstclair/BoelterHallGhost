using UnityEngine;
using System.Collections;

public class MouseHover : MonoBehaviour {

	void start(){
		GetComponent<Renderer>().material.color = Color.black;
	}

	void onMouseEnter(){
		GetComponent<Renderer>().material.color = Color.blue;
	}

	void onMouseExit(){
		GetComponent<Renderer>().material.color = Color.blue;
	}
	void onMouseDown(){
		Application.LoadLevel ("Hallway");
	}
}
