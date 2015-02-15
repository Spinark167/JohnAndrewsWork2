using UnityEngine;
using System.Collections;

public class FloatKeyScript : MonoBehaviour {

	public float MaxHeight;
	public float MinHeight;

	// Use this for initialization
	void Start () {
		gameObject.rigidbody.velocity = new Vector3 (0f, 1.5f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= MinHeight) {
			gameObject.rigidbody.velocity = new Vector3(0f, 1.5f, 0f);
		}
		if (gameObject.transform.position.y >= MaxHeight) {
			gameObject.rigidbody.velocity = new Vector3(0f, -1.5f, 0f);
		}
	}
}
