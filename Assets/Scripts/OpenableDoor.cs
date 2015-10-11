﻿using UnityEngine;
using System.Collections;

public class OpenableDoor : MonoBehaviour {
	public int doorOpenAngle = -90;
	public bool playerEnter, doorOpen;
	public float openSpeed = 1;
	public Vector3 closedRotation, creakRotation, openRotation;

	void Start () {
		// Obtains the default x, y, z rotational values for a closed door
		closedRotation = transform.eulerAngles;
		// Sets the rotation on the door when opening
		openRotation = new Vector3 (closedRotation.x, closedRotation.y + doorOpenAngle, closedRotation.z);
	}
	
	// Update is called once per frame
	void Update () {
		// If the door flag is true, open the door
		if (doorOpen) {
			// slightly open door
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRotation, Time.deltaTime * openSpeed);
			// fast open
		}
		// If the door flag is false, close the door
		else {
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, closedRotation, Time.deltaTime * openSpeed);
		}
		// Toggle door state if user is within the collision box
		if (Input.GetKeyDown (KeyCode.E) && playerEnter) 
			doorOpen = !doorOpen;
	}
	
	
	// Toggle entry flag when user within close proximity of the door
	void OnTriggerEnter(Collider player) {
		if (player.gameObject.tag == "Player")
			playerEnter = true;
	}
	
	void OnTriggerExit(Collider player) {
		if (player.gameObject.tag == "Player") 
			playerEnter = false;
	}
	
}
