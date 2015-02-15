using UnityEngine;
using System.Collections;

public class AIStopScript : MonoBehaviour {

	public float MinDist;

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

		AILookingScript looking = gameObject.GetComponent<AILookingScript>();

		if (distance <= MinDist) {
			looking.enabled = false;
		} else {
			looking.enabled = true;
		}
	}
}
