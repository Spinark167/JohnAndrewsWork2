using UnityEngine;
using System.Collections;

public class AIMovementScript : MonoBehaviour {

	void Update() {

		float rotOfObj = transform.rotation.eulerAngles.y;
		//Debug.Log (rotOfObj);
		float radRotObj = ((rotOfObj * Mathf.PI) / 180);
	
		float factorX = Mathf.Sin (radRotObj);
		float factorZ = Mathf.Cos (radRotObj);
	
		//Debug.Log (factorX);
		//Debug.Log (factorZ);
	
		/*if (diffZ > 0) {
			factorZ = factorZ * -1;
		}*/
	
		if (rotOfObj > 270 && rotOfObj < 360) {
			factorX = factorX * -1;
		}
		if (rotOfObj > 0 && rotOfObj < 90) {
			factorX = factorX * -1;
		}
		if (rotOfObj > 90 && rotOfObj < 180) {
			factorX = factorX * -1;
		}
		if (rotOfObj > 180 && rotOfObj < 270) {
		
			factorX = factorX * -1;
		}
	
		if (rotOfObj < 2.5 || rotOfObj > 357.5) {
			factorX = 0;
			factorZ = 1;
		}
		if (rotOfObj < 92.5 && rotOfObj > 87.5) {
			factorX = -1;
			factorZ = 0;
		}
		if (rotOfObj < 182.5 && rotOfObj > 177.5) {
			factorX = 0;
			factorZ = -1;
		}
		if (rotOfObj < 272.5 && rotOfObj > 267.5) {
			factorX = 1;
			factorZ = 0;
		}
	
		rigidbody.velocity = new Vector3 (1f * factorZ, 0f, 1f * factorX);
	
		if (rigidbody.velocity.x >= 2.5) {
			rigidbody.velocity = new Vector3 (2.4f, rigidbody.velocity.y, rigidbody.velocity.z);	
		}
		if (rigidbody.velocity.x <= -2.5) {
			rigidbody.velocity = new Vector3 (-2.4f, rigidbody.velocity.y, rigidbody.velocity.z);	
		}
		if (rigidbody.velocity.z >= 2.5) {
			rigidbody.velocity = new Vector3 (rigidbody.velocity.x, rigidbody.velocity.y, 2.4f);	
		}
		if (rigidbody.velocity.z <= -2.5) {
			rigidbody.velocity = new Vector3 (rigidbody.velocity.x, rigidbody.velocity.y, -2.4f);	
		}
	}
}
