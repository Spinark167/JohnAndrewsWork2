using UnityEngine;
using System.Collections;

public class PickUpKeyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Player") {
			GameObject end = GameObject.Find ("EndBlock");
			EndBlockScript endScript = end.GetComponent<EndBlockScript>();
			endScript.Flip ();

			Destroy(gameObject);
		}
	}

}
