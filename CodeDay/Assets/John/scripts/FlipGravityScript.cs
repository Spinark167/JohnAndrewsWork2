using UnityEngine;
using System.Collections;

public class FlipGravityScript : MonoBehaviour {

	public KeyCode FlipGravity;

	float timer = 0f;
	//float timer2 = 0f;

	bool gravityFlip = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (FlipGravity) && timer <= 0) {
		if(gravityFlip == true) {
			Physics.gravity = new Vector3(0f,9.81f,0f);
			gameObject.transform.Rotate( 180f, 0f, 0f);
			//this is where the animation should play
			timer = 2f;
			gravityFlip = false;
		}else{
			Physics.gravity = new Vector3(0f,-9.81f,0f);
			gameObject.transform.Rotate( 180f, 0f, 0f);
			//this is where the animation should play
			timer = 2f;
			gravityFlip = true;
		}
	}

	}

	void FixedUpdate() {
		timer -= .02f;
		//timer2 -= .02f;

		/*if (gameObject.transform.rotation.eulerAngles.x <= 175 && gravityFlip == false) {
			gameObject.transform.Rotate(5f, 0f, 0f);
		}

		if (gameObject.transform.rotation.eulerAngles.x >= 5 && gravityFlip == true) {
			gameObject.transform.Rotate(5f, 0f, 0f);
		}*/
	}
}
