using UnityEngine;
using System.Collections;

public class EndBlockScript : MonoBehaviour {

	bool end = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(){
		if (end == true) {
			Application.LoadLevel("LevelClearScreen");
		}
	}

	public void Flip () {
		end = true;
	}
}
