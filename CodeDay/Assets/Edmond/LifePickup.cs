using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {

	public AudioClip pickup;

	void OnTriggerEnter () {
		HealthGUI.healthIncrease();
		AudioSource.PlayClipAtPoint (pickup, Camera.main.transform.position);
		Destroy (gameObject);
}
}
