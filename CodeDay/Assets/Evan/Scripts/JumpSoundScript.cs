using UnityEngine;
using System.Collections;

public class JumpSoundScript : MonoBehaviour {
	public AudioClip blipAudio;

	void OnCollisionEnter(Collision Other){
		if(Other.gameObject.tag == "ground"){
			AudioSource.PlayClipAtPoint(blipAudio, transform.position,.15f);
		}
	}
}
