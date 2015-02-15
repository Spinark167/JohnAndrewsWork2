using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {

	public AudioClip pickup;

	void OnTriggerEnter () {
		GameObject health = GameObject.Find ("HealthGUI");
		HealthGUI healthgui = health.GetComponent<HealthGUI>();
		healthgui.healthIncrease();
		AudioSource.PlayClipAtPoint (pickup, Camera.main.transform.position);
		Destroy (gameObject);
}
}
