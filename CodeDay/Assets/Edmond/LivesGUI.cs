using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesGUI : MonoBehaviour {
	
	Text instruction;
	public static int lives = 3;

	void Start () {
		lives = 3;
	}
	
	void Update () {
		instruction = GetComponent<Text>();
		instruction.text = "Lives: " + lives;
	}

	public void Death () {
		lives--;
		if (lives <=  0) {
			Application.LoadLevel("Game Over");
		}
		else {
			Application.LoadLevel("Evan");
		}
	}
}