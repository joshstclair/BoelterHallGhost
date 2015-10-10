using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int health;

	private void endGame(){
	}

	public void startGame(){
		Application.LoadLevel ("mainScene");
	}

	private void reStartGame(){	
		Application.LoadLevel (Application.loadedLevelName);
	}

}
