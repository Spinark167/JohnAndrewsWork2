using UnityEngine;
using System.Collections;

public class BulletDeathScript : MonoBehaviour {

	float timer = .5f;

	public AudioClip blipAudio;

	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint(blipAudio, transform.position, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter (Collision other) {
		Destroy (gameObject);

		if (other.gameObject.tag == "AI") {
			Destroy(other.gameObject); 
			GameObject score = GameObject.Find ("Score");
			ScoreGUI heathgui = score.GetComponent<HealthGUI>();
			heathgui.scoreIncrease();
		}
	}

	void FixedUpdate () {
		timer -= .02f;
	}
}
