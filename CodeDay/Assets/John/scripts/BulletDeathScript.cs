using UnityEngine;
using System.Collections;

public class BulletDeathScript : MonoBehaviour {

	float timer = .5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter (Collision other) {
		Destroy (gameObject);

		if (other.gameObject.tag == "Player") {
			GameObject health = GameObject.Find ("Health");
			HealthGUI heathgui = health.GetComponent<HealthGUI>();
			heathgui.healthDecrease();
		}

		if (other.gameObject.tag == "AI") {
			Destroy(other.gameObject); 
		}
	}

	void FixedUpdate () {
		timer -= .02f;
	}
}
