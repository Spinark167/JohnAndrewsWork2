using UnityEngine;
using System.Collections;

public class CapMovement : MonoBehaviour {
	public KeyCode moveFoward,
	moveLeft,moveBackward,moveRight, stop;
	
	public KeyCode lookLeft, lookRight,jump;
	
	public KeyCode invertGravity;
	bool isInverted = false;
	float time = 0f;
	float timer = 1.5f;
	public float jumpHeight;
	bool hasFlipped;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float DegValueX = (transform.eulerAngles.y * Mathf.PI)/180f;
		float factorX = Mathf.Sin(DegValueX);
		float factorZ = Mathf.Cos(DegValueX);
		if(Input.GetKey (moveFoward))
			move (factorX, factorZ, 15f,15f);
		if(Input.GetKey (moveLeft))
			move (factorZ, factorX, -15f,15f);
		if(Input.GetKey (moveBackward))
			move (factorX, factorZ, -15f,-15f);
		if(Input.GetKey (moveRight))
			move (factorZ, factorX, 15f,-15f);
		if(Input.GetKey (stop))
			rigidbody.velocity = new Vector3(0f,rigidbody.velocity.y,0f);
		if (Input.GetKey (invertGravity) && timer <= 0 ) {
			isInverted = !isInverted;
			hasFlipped = false;
			timer = 1.5f;
		}
		if (isInverted ) {
			Physics.gravity = new Vector3 (0f, 9.81f, 0f);

		
		} else {
			Physics.gravity = new Vector3 (0f, -9.81f, 0f);

		}
		if (!hasFlipped) {
			gameObject.transform.Rotate (180, 0, 0);
			hasFlipped = true;
		}
		if (rigidbody.velocity.x >= 2.5) 
			rigidbody.velocity = new Vector3(2.4f ,rigidbody.velocity.y ,rigidbody.velocity.z);	
		
		if (rigidbody.velocity.x <= -2.5) 
			rigidbody.velocity = new Vector3(-2.4f ,rigidbody.velocity.y ,rigidbody.velocity.z);	
		
		if (rigidbody.velocity.z >= 2.5) 
			rigidbody.velocity = new Vector3(rigidbody.velocity.x ,rigidbody.velocity.y ,2.4f);	

		if (rigidbody.velocity.z <= -2.5) 
			rigidbody.velocity = new Vector3(rigidbody.velocity.x ,rigidbody.velocity.y ,-2.4f);	

		if (Physics.gravity.x > 0) {
			jumpHeight = jumpHeight*-1;
		}
	}
	void move(float factor1,float factor2, float x,float z){
		rigidbody.AddForce (x * factor1, 0f, z*factor2);
	}
	void FixedUpdate(){
		time -= .02f;
		timer -= .02f;
		if (Input.GetKey (lookLeft))
			transform.Rotate (0f, -1.5f, 0f);
		if (Input.GetKey (lookRight))
			transform.Rotate (0f, 1.5f, 0f);
		if (Input.GetKey (jump) && time <= 0f) {
			rigidbody.AddForce (0f, jumpHeight, 0f);
			time = 1f;
		}

		if (gameObject.transform.rotation.eulerAngles.x <= 175 && !isInverted) {
			gameObject.transform.Rotate(5f,0f,0f);
		}
		if (gameObject.transform.rotation.eulerAngles.x <= 175 && isInverted) {
			gameObject.transform.Rotate(5f,0f,0f);
		}

	}
}
