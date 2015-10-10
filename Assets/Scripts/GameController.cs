using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int health;

	private void endGame(){
	}

	public void startGame(){
		Application.LoadLevel ("Hallway");
	}

	private void reStartGame(){	
		Application.LoadLevel (Application.loadedLevelName);
	}

}
