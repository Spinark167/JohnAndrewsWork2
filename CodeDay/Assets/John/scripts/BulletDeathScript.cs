using UnityEngine;
using System.Collections;

public class BulletDeathScript : MonoBehaviour {

	float timer = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			Destroy(gameObject);
		}
	}

	void FixedUpdate () {
		timer -= .02f;
	}
}
