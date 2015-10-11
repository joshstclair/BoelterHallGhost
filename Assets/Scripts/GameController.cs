using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public int health;
	//need sound engine her
	//more luck you have, less likely you will find something scary
	//anything less than 3 you will always find something scary
	public int luckFactor;
	public GhoulScript ghoul;
	
	void Start(){
		ghoul = (GhoulScript)GameObject.Find ("ghoul").GetComponent ("GhoulScript");
	}
	
	void update(){
		//check for health
		if (health == 0)
			endGame ();
	}
	
	private void endGame(){
		//end game method goes here
	}
	
	public void startGame(){
		Application.LoadLevel ("mainScene");
		health = 3;
	}
	
	private void reStartGame(){	
		Application.LoadLevel (Application.loadedLevelName);
	}
	
	public void loseHealth(int hp){
		health -= hp;
	}
	
	public void doorOpened(){
		ghoul.appear ();
		//based on health do these things
		if (true) {
			//Instantiate(ghoul, transform.position + transform.forward. * 3.0 , transform.rotation);
			//make scary noise pop out stuff.
		}
		if (Random.Range (0, luckFactor) < (2+health)) {
			//lose health
		}
	}
}