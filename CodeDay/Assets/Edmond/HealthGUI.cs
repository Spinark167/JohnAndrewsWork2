using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthGUI : MonoBehaviour {

	Text instruction;
	public static int health = 400;

	void Start () {
		health = 400;
	}
	
	void Update () {
		instruction = GetComponent<Text>();
		instruction.text = "Hit Points: " + health;
	}
	
	public static void healthIncrease () {
		health++;
	}

	public static void healthDecrease () {
		health--;
		if (health <= 0) {
			LivesGUI.Death();
				}
		}

	public static void instantDeath () { {
		health = 0;
		LivesGUI.Death ();
}
}
}