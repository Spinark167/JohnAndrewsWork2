using UnityEngine;
using System.Collections;

public class DestroyAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject annoyingSounds = GameObject.Find ("One shot audio");
		Destroy (annoyingSounds.gameObject);
	}
}
