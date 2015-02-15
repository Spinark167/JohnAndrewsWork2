using UnityEngine;
using System.Collections;

public class AIShootScript : MonoBehaviour {

	public GameObject thePrefab;

	
	//public KeyCode shoot;
	
	public float Timer;
	float TimeSet = 1.5f;

	void Start () {
		
	}

	void Update () {

		float DegValX = ((transform.eulerAngles.y * Mathf.PI) / 180);
		float factorX = Mathf.Sin (DegValX);
		float factorZ = Mathf.Cos (DegValX);

		//GameObject cameraPivot = GameObject.Find ("GrundHolder1");
		//float rotUp = cameraPivot.transform.rotation.eulerAngles.x;

		//float rotUpRad = ((rotUp * Mathf.PI) / 180);
		//float factorYUp = Mathf.Sin (rotUpRad);
		//float factorYOut = Mathf.Cos (rotUpRad);
		
		if (/*Input.GetKey (shoot) &&*/ Timer <= 0) {

			Timer = TimeSet;
			GameObject bullet = (GameObject)Instantiate (thePrefab, transform.position, /*Quaternion.Euler(Vector3(0, 0, 90))*/ transform.rotation);
			
			bullet.rigidbody.velocity = new Vector3(20f * factorX /** factorYOut*/, /*-45f * factorYUp*/0f , 20f * factorZ /** factorYOut*/);


		}
	}
	
	void FixedUpdate(){
		Timer -= .02f;
	}
}