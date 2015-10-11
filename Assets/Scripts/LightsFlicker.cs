using UnityEngine;
using System.Collections;

public class LightsFlicker : MonoBehaviour {
	
	public Light flashingLight;
	// public Light secondFlashingLight;
	private float randomNumber;
	
	void Start(){
		
		flashingLight.enabled = false;
		//secondFlashingLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		randomNumber = Random.value;
		
		if (randomNumber <= 0.95f) {
			
			flashingLight.enabled = true;
			// secondFlashingLight.enabled = true;
		} else {
			
			flashingLight.enabled = false;
			//  secondFlashingLight.enabled = false;
			
		}
		
	}
}