using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthGUI : MonoBehaviour {

	Text instruction;
	public static int health = 20;

	void Start () {
		health = 20;
	}
	
	void Update () {
		instruction = GetComponent<Text>();
		instruction.text = "Hit Points: " + health;
	}
	
	public void healthIncrease () {
		health++;
	}

	public void healthDecrease () {
		health--;
		if (health <= 0) {
			GameObject death = GameObject.Find ("LivesGUI");
			LivesGUI deathgui = death.GetComponent<LivesGUI>();
			deathgui.Death();
				}
		}

	public void instantDeath () { {
		health = 0;
			GameObject death = GameObject.Find ("LivesGUI");
			LivesGUI deathgui = death.GetComponent<LivesGUI>();
		deathgui.Death ();
}
}
}