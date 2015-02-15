using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGUI : MonoBehaviour {
	
	Text instruction;
	public static int score = 0;
	
	void Update () {
		instruction = GetComponent<Text>();
		instruction.text = "Score: " + score;
	}

	public void scoreIncrease () {
		score++;
		}
	
}
