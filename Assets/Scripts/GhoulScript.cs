using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class GhoulScript : MonoBehaviour {

	private AudioSource source;

	private AudioClip monsterScare;

	void Start () {
		//grab the camera to know the position of x and y and z
		source = GetComponent<AudioSource> ();
	}
	
	void Update() {
	}
	
	public void appear() {
		Vector3 temp= Camera.main.transform.position + Camera.main.transform.forward * 2;
		Vector3 temp2 = new Vector3 (temp.x, temp.y - 2, temp.z);
		transform.position = temp2;


	}
}