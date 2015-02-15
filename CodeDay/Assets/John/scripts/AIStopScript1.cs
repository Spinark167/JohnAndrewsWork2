using UnityEngine;
using System.Collections;

public class AIStopScript1 : MonoBehaviour {

	public float MinDist;
	public float MaxDist;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject guy = GameObject.Find ("Guy");
		float guyX = guy.transform.position.x;
		float guyZ = guy.transform.position.z;

		float AIx = gameObject.transform.position.x;
		float AIz = gameObject.transform.position.z;

		float diffX = guyX - AIx;
		float diffZ = guyZ - AIz;

		float partDist = diffX * diffX + diffZ * diffZ;
		float distance = Mathf.Sqrt (partDist);

		AIMovementScript looking = gameObject.GetComponent<AIMovementScript>();

		GameObject guns1 = GameObject.Find ("UpperRight1");
		AIShootScript shooting1 = gameObject.GetComponent<AIShootScript>();

		GameObject guns2 = GameObject.Find ("UpperLeft1");
		AIShootScript shooting2 = gameObject.GetComponent<AIShootScript>();

		GameObject guns3 = GameObject.Find ("LowerRight1");
		AIShootScript shooting3 = gameObject.GetComponent<AIShootScript>();

		GameObject guns4 = GameObject.Find ("LowerRight1");
		AIShootScript shooting4 = gameObject.GetComponent<AIShootScript>();

		if (distance <= MinDist || distance >= MaxDist) {
			looking.enabled = false;
			gameObject.rigidbody.velocity = new Vector3(0f,0f,0f);
		} 
		if (distance > MinDist || distance < MaxDist){
			looking.enabled = true;
		}
		/*if (distance > MaxDist) {
			shooting1.enabled = false;
			shooting2.enabled = false;
			shooting3.enabled = false;
			shooting4.enabled = false;
		} 
		if (distance <= MaxDist) {
			shooting1.enabled = true;
			shooting2.enabled = true;
			shooting3.enabled = true;
			shooting4.enabled = true;
		}*/
	}
}
