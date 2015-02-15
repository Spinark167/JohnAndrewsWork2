using UnityEngine;
using System.Collections;

public class LookScript : MonoBehaviour {
	public KeyCode lookUP;
	public KeyCode lookDown;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		if(Input.GetKey (lookUP)){
			gameObject.transform.Rotate(1.5f,0f,0f);

		}
		if(Input.GetKey (lookDown)){
			gameObject.transform.Rotate(-1.5f,0f,0f);
			
		}
	}
}
